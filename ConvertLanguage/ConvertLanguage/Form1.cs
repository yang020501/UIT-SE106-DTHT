using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.CSharp;

namespace ConvertLanguage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        private void ChangeColor(string find,Color color) // đổi màu từ được truyền 
        {            
            if (rtxOutput.Text.Contains(find))
            {
                var matchString = Regex.Escape(find);
                foreach (Match match in Regex.Matches(rtxOutput.Text, matchString))
                {
                    rtxOutput.Select(match.Index, find.Length);
                    rtxOutput.SelectionColor = color;
                    rtxOutput.Select(rtxOutput.TextLength, 0);
                    rtxOutput.SelectionColor = rtxOutput.ForeColor;
                };
            }
        }

        public string name_result;
        public string type_result;
        public string value_result;
        public bool isArray = false;

        private void btniconBuild_Click(object sender, EventArgs e)
        {

            CSharpCodeProvider codeProvider = new CSharpCodeProvider();
            ICodeCompiler icc = codeProvider.CreateCompiler();
            string Output =  "Application.exe";
            textBox2.Text = "";
            CompilerParameters parameters = new CompilerParameters();
            parameters.GenerateExecutable = true;
            parameters.OutputAssembly = Output;
            CompilerResults results = icc.CompileAssemblyFromSource(parameters,rtxOutput.Text);
            if (results.Errors.Count > 0)
            {
                textBox2.ForeColor = Color.Red;
                textBox2.Text = "Error!";
                foreach (CompilerError CompErr in results.Errors)
                {
                   textBox3.Text = textBox3.Text +
                                "Line number " + CompErr.Line +
                                ", Error Number: " + CompErr.ErrorNumber +
                                ", '" + CompErr.ErrorText + ";" +
                                Environment.NewLine + Environment.NewLine;
                }
            }
            else
            {
                
                textBox2.ForeColor = Color.Blue;
                textBox2.Text = "Success!";              
                Process.Start(Output);
            }
           

        }
        private void btnCsharp_Click(object sender, EventArgs e)
        {
            ConvertCSharp();
            MakeColorCSharp();
            //List<string[]> s = doRegex.doPost(doRegex.cutPost(rtxInput.Text));
            //foreach (string[] item in s)
            //{
            //    for (int i = 0; i < item.Length; i++)
            //    {
            //        rtxOutput.Text += item[i] + " ";
            //    }
            //    rtxOutput.Text += "\n";
            //}



        }

        private void MakeColorCSharp()
        {
            string[] blue = { "using", "float", "public", "static", "void", "int", "string", "bool", "namespace","ref"};
            string[] pink = { "if", "else", "return" };
            string[] green = { "Console", "WriteLine", "ReadLine" };
            for(int i=0;i<blue.Length;i++)
            {
                ChangeColor(blue[i], Color.Blue);
            }
            for (int i = 0; i < pink.Length; i++)
            {
                ChangeColor(pink[i], Color.Violet);
            }
            for (int i = 0; i < pink.Length; i++)
            {
                ChangeColor(green[i], Color.Green);
            }
            ChangeColor("Program",Color.Orange);
                     
        }

        private void btnCpp_Click(object sender, EventArgs e)
        {
            ConvertCPP();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            rtxInput.Clear();
            rtxOutput.Clear();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(openFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(openFile.FileName);
                rtxInput.Text = read.ReadToEnd().Trim();               
                read.Close();               
            }
            
        }       
        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFile.ShowDialog();          

        }       

        private void ConvertCPP()
        {
            string result;
            CPp file = new CPp();
            result = "";
            rtxOutput.Text = Regex.Replace(file.Result, @"x:R", result);
        }

        private void ConvertCSharp()
        {
            try // xử lý thay đôit cho form định sẵn
            {
                string result;
                CSharp file = new CSharp();
                result = file.formNhap() + file.formXuat() + file.formCheck(doRegex.cutPre(rtxInput.Text)) + file.formFunction() + file.formMain(); // make form CSharp
                result = Regex.Replace(result, @"name", getName());  // replace name 
                result = Regex.Replace(result, @"reftype", getRequestSharp("reftype")); // replace ref type
                result = Regex.Replace(result, @"nonrefType", getRequestSharp("nonrefType")); // replace non ref type
                result = Regex.Replace(result, @"type", getRequestSharp("type")); // replace type 
                result = Regex.Replace(result, @"nonType", getRequestSharp("nonType")); // replace nontype 
                result = Regex.Replace(result, @"resultType", getRequestSharp("resultType")); // replace kiểu của kết quả
                result = Regex.Replace(result, @"rstValue", getRequestSharp("rstValue")); // replacel kiểu value khi khai báo
                result = Regex.Replace(result, @"result", getRequestSharp("result"));// replace tên biến kết quả
                result = Regex.Replace(result, @"intro", getRequestSharp("intro")); // replace khai báo trong hàm main
                result = Regex.Replace(result, @"nhaphere", getRequestSharp("nhaphere")); // replace nhập 
                result = Regex.Replace(result, @"post", getFunction()); // replace post 
                rtxOutput.Text = Regex.Replace(file.Result, @"x:R", result);
            }
            catch (Exception )
            {
                MessageBox.Show("Chưa có dữ liệu", "Lưu Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
            }
        }

        public static string layKhoang(string s)
        {
            int index1 = 0;
            int index2 = 0;
            string vari = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '{')
                {
                    index1 = i;
                }

                if (s[i] == '}')
                {
                    index2 = i;
                }

                if (s[i] == 'T' && s[i + 1] == 'H')
                {
                    vari = s.Substring(2, i - 2);
                }

            }


            string min = ""; string max = "";
            string khoang = s.Substring(index1 + 1, index2 - index1);

            for (int i = 0; i < khoang.Length; i++)
            {
                if (khoang[i] == '.' && khoang[i - 1] == '.')
                {
                    min = khoang.Substring(0, i - 1);
                    max = khoang.Substring(i + 1, khoang.Length - i - 2);
                    break;
                }
            }
            int check;
            if (int.TryParse(min, out check))
            {
                check -= 1;
                min = check.ToString();
            }

            string result = "for(int " + vari + " = " + min + "; " + vari + " < " + max + "; " + vari + "++)";

            return result;
        }

        private string getFunction()
        {
            if(isArray == false)
            {              
                string result = "";
                List<string[]> list = doRegex.doPost(doRegex.cutPost(rtxInput.Text));
                foreach (string[] item in list)
                {
                    result += "else if(";
                    for (int i = 1; i < item.Length; i++)
                    {
                        result += item[i] + " && ";
                    }
                    result = result.Remove(result.Length - 4); // xoá dấu && cuối
                    result += ")" +
                        doRegex.tab(3) + "{" +
                        doRegex.tab(4) + item[0] + ";" +
                        doRegex.tab(3) + "}" +
                        doRegex.tab(3);

                }
                result = result.Remove(0, 5);// xoá else đầu
                result = Regex.Replace(result, @"FALSE", "false");
                result = Regex.Replace(result, @"TRUE", "true");
                return result;
            }
            else if(type_result == "bool" && isArray == true)
            {
                isArray = false;
                string result = "";
                string post = doRegex.cutPost(rtxInput.Text);

                string[] re;
                re = Post.Tach_PostArray(post);

                string[] loai = new string[2];
                string Ham = "";

                // Xữ lí dòng 1
                if (re[0].Contains("VM") || re[0].Contains("TT"))
                {
                    result += "\t\t\t" + layKhoang(re[0]) + "\n";
                    result += "\t\t\t{\n";
                    result += "\t\t\t\tbool check=false;\n";
                }

                for (int i = 0; i < re.Length - 1; i++)
                {
                    if (re[i].Contains("VM"))
                    {
                        loai[i] = "VM";
                    }
                    else if (re[i].Contains("TT"))
                    {
                        loai[i] = "TT";
                    }
                    else
                    {
                        loai[i] = "";
                    }
                }

                if (loai[0] == "VM")
                {
                    if (loai[1] == "VM") // VM-VM
                    {
                        re[2] = re[2].Replace('(', '[');
                        re[2] = re[2].Replace(')', ']');
                        Ham += "\tif(!" + re[2] + ")\n";
                        Ham += "\t\t\t\t\t{\n";
                        Ham += "\t\t\t\t\t\tkq = false;\n"; // chỉnh khi vào code chính
                        Ham += "\t\t\t\t\t\treturn kq;\n";
                        Ham += "\t\t\t\t\t}\n";
                        Ham += "\t\t\t\t}\n";

                        result = "kq = true;\n" + result; // chỉnh khi vào code chính
                    }
                    else if (loai[1] == "TT") // VM-TT
                    {
                        re[2] = re[2].Replace('(', '[');
                        re[2] = re[2].Replace(')', ']');
                        
                        Ham += "\tif(" + re[2] + ")\n";
                        Ham += "\t\t\t\t\t{\n";
                        Ham += "\t\t\t\t\t\tcheck = true;\n";
                        Ham += "\t\t\t\t\t}\n\n";
                        Ham += "\t\t\t\t}\n\n";
                        Ham += "\t\t\t\tif(check == false)\n";
                        Ham += "\t\t\t\t{\n";
                        Ham += "\t\t\t\t\tkq = false;\n"; // chỉnh khi vào code chính
                        Ham += "\t\t\t\t\treturn kq;\n";
                        Ham += "\t\t\t\t}";


                        result = "kq = true;\n" + result; // chỉnh khi vào code chính
                    }
                    else // VM
                    {
                        re[1] = re[1].Replace('(', '[');
                        re[1] = re[1].Replace(')', ']');
                        Ham += "if(!" + re[1] + ")\n";
                        Ham += "\t\t\t\t{\n";
                        Ham += "\t\t\t\t\tkq = false;\n";
                        Ham += "\t\t\t\t\treturn kq;\n";
                        Ham += "\t\t\t\t}\n";

                        result = "kq = true;\n" + result; // chỉnh khi vào code chính
                    }
                }
                else if (loai[0] == "TT")
                {
                    if (loai[1] == "VM") // TT-VM
                    {
                        re[2] = re[2].Replace('(', '[');
                        re[2] = re[2].Replace(')', ']');

                        result = Regex.Replace(result, @"check=false;", " check=true;");
                        
                        Ham += "\tif(!" + re[2] + ")\n";
                        Ham += "\t\t\t\t\t{\n";
                        Ham += "\t\t\t\t\t\tcheck = false;\n";
                        Ham += "\t\t\t\t\t}\n\n";
                        Ham += "\t\t\t\t}\n\n";
                        Ham += "\t\t\t\tif(check == true)\n";
                        Ham += "\t\t\t\t{\n";
                        Ham += "\t\t\t\t\tkq = true;\n"; // chỉnh khi vào code chính
                        Ham += "\t\t\t\t\treturn kq;\n";
                        Ham += "\t\t\t\t}";


                        result = "kq = false;\n" + result; // chỉnh khi vào code chính
                    }
                    else if (loai[1] == "TT") // TT-TT
                    {
                        re[2] = re[2].Replace('(', '[');
                        re[2] = re[2].Replace(')', ']');
                        Ham += "\tif(" + re[2] + ")\n";
                        Ham += "\t\t\t\t\t{\n";
                        Ham += "\t\t\t\t\t\tkq = true;\n"; // chỉnh khi vào code chính
                        Ham += "\t\t\t\t\t\treturn kq;\n";
                        Ham += "\t\t\t\t\t}\n";
                        Ham += "\t\t\t\t}\n";

                        result = "kq = false;\n" + result; // chỉnh khi vào code chính

                    }
                    else // TT
                    {
                        re[1] = re[1].Replace('(', '[');
                        re[1] = re[1].Replace(')', ']');
                        Ham += "if(" + re[1] + ")\n";
                        Ham += "\t\t\t\t{\n";
                        Ham += "\t\t\t\t\tkq = true;\n"; // chỉnh khi vao code chính
                        Ham += "\t\t\t\t\treturn kq;\n";
                        Ham += "\t\t\t\t}\n";

                        result = "kq = false;\n" + result; // chỉnh khi vào code chính
                    }
                }               

                // Xữ lí dòng 2

                if (re[1].Contains("VM") || re[1].Contains("TT"))
                {
                    result += "\t\t\t\t" + layKhoang(re[1]) + "\n";
                    result += "\t\t\t\t{\n";
                    if (re[2] == "")
                    {
                        result += "\t\t\t\t\t\t}\n";
                    }
                }
                else
                {
                    result += "\t\t\t\t" + Ham + "\n";
                }

                // Xữ lí dòng 3 nếu có

                if (re[2] == "")
                {
                    result += "\t\t\t}";                   

                    return result;
                }
                else
                {

                    result += "\t\t\t\t" + Ham + "\n";

                    result += "\t\t\t}";
                   
                }

                return result;
            }
            else
            {
                return "";
            }
           
        }

        private string getRequestSharp(string s)
        {
            string result = "";
            List<Var> Variables = new List<Var>(); // một list chứa các class Var(tên biến,kiểu,dữ liệu kiểu) 
            if (s == "reftype")
            {
                string[] tmp = doRegex.doMain(doRegex.cutMain(rtxInput.Text)); // một mảng chuỗi đc cắt của dòng main(khai báo)
                for (int i = 1; i < tmp.Length - 1; i++)
                {
                    Variables.Add(new Var(tmp[i]));
                }
                foreach (Var item in Variables)
                {
                    result += "ref " + item.Type + " " + item.Name + ",";
                }
                result = result.Remove(result.Length - 1); // xoá dấu phẩy cuối
            }
            else if (s == "nonrefType")
            {
                string[] tmp = doRegex.doMain(doRegex.cutMain(rtxInput.Text)); // một mảng chuỗi đc cắt của dòng main(khai báo)
                for (int i = 1; i < tmp.Length - 1; i++)
                {
                    Variables.Add(new Var(tmp[i]));
                }
                foreach (Var item in Variables)
                {
                    result += "ref " + item.Name + ",";
                }
                result = result.Remove(result.Length - 1); // xoá dấu phẩy cuối
            }
            else if (s=="type")
            {
                string[] tmp = doRegex.doMain(doRegex.cutMain(rtxInput.Text)); // một mảng chuỗi đc cắt của dòng main(khai báo)
                for (int i = 1; i < tmp.Length - 1; i++)
                {
                    Variables.Add(new Var(tmp[i]));
                }
                foreach (Var item in Variables)
                {
                    result += item.Type + " " + item.Name + ",";
                }
                result = result.Remove(result.Length - 1); // xoá dấu phẩy cuối
            }
            else if (s == "nonType")
            {
                string[] tmp = doRegex.doMain(doRegex.cutMain(rtxInput.Text)); // một mảng chuỗi đc cắt của dòng main(khai báo)
                for (int i = 1; i < tmp.Length - 1; i++)
                {
                    Variables.Add(new Var(tmp[i]));
                }
                foreach (Var item in Variables)
                {
                    result += item.Name + ",";
                }
                result = result.Remove(result.Length - 1); // xoá dấu phẩy cuối
            }
            else if(s =="result")
            {
                string[] tmp = doRegex.doMain(doRegex.cutMain(rtxInput.Text));
                result = new Var(tmp[tmp.Length - 1]).Name;
                name_result = new Var(tmp[tmp.Length - 1]).Name;
            }    
            else if(s=="resultType")
            {
                string[] tmp = doRegex.doMain(doRegex.cutMain(rtxInput.Text));
                result = new Var(tmp[tmp.Length - 1]).Type;
                type_result = new Var(tmp[tmp.Length - 1]).Type;
            }
            else if (s == "rstValue")
            {
                string[] tmp = doRegex.doMain(doRegex.cutMain(rtxInput.Text));
                result = new Var(tmp[tmp.Length - 1]).Value;
                value_result = new Var(tmp[tmp.Length - 1]).Value;
            }
            else if (s == "intro")
            {
                string[] tmp = doRegex.doMain(doRegex.cutMain(rtxInput.Text)); // một mảng chuỗi đc cắt của dòng main(khai báo)
                for (int i = 1; i < tmp.Length - 1; i++)
                {
                    Variables.Add(new Var(tmp[i]));
                }
                foreach (Var item in Variables)
                {
                    result += item.Type +" "+ item.Name + " = " + item.Value + ";"+doRegex.tab(3);
                }
                result = result.Remove(result.Length - 4); // xoá dấu \n tab cuối
            }
            else if (s == "nhaphere")
            {
                string[] tmp = doRegex.doMain(doRegex.cutMain(rtxInput.Text)); // một mảng chuỗi đc cắt của dòng main(khai báo)
                for (int i = 1; i < tmp.Length - 1; i++)
                {
                    Variables.Add(new Var(tmp[i]));
                }
                foreach(Var item in Variables)
                {
                    if(item.Type == "float[]" || item.Type == "int[]" ) // nếu là mảng 
                    {
                        result += "Console.Write(\"Moi nhap so phan tu: \");" + 
                                doRegex.tab(3)+"n = " + "type.Parse(Console.ReadLine());"+
                                doRegex.tab(3) + item.Name+" = new " + doRegex.Arr(item.Type)+"[n];";
                        result += doRegex.tab(3) + "for (int i = 0; i < n; i++)" +
                                doRegex.tab(3) + "{" +
                                doRegex.tab(4) + "Console.Write(\"Nhap phan tu thu {0}: \",i+1);" +
                                doRegex.tab(4) + item.Name + "[i] = " + doRegex.Arr(item.Type)+ ".Parse(Console.ReadLine());" +
                                doRegex.tab(3) + "}";
                        result = Regex.Replace(result, @"type", new Var(tmp[tmp.Length - 2]).Type);
                        isArray = true;
                        return result;
                    }    
                    else // biến thường 
                    {
                        result += doRegex.tab(3)+ "Console.Write(\"Moi nhap " + item.Name + " : \");" +
                                 doRegex.tab(3) + item.Name + " = " + item.Type + ".Parse(Console.ReadLine());";
                        
                    }
                   
                }    
                
            }
            return result;
        }

        private string getName() // dùng chung cho cả C# C++
        {
            return doRegex.doMain(doRegex.cutMain(rtxInput.Text))[0]; 
        }

      
    }
}
