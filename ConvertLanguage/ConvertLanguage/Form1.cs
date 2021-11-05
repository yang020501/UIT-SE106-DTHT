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
        private void ChangeColorPat(string find, Color color) // đổi màu pattern được truyền 
        {
            if (Regex.IsMatch(rtxOutput.Text,find))
            {
                foreach (Match match in Regex.Matches(rtxOutput.Text, find))
                {
                    rtxOutput.Select(match.Index, match.Value.Length);
                    rtxOutput.SelectionColor = color;
                    rtxOutput.Select(rtxOutput.TextLength, 0);
                    rtxOutput.SelectionColor = rtxOutput.ForeColor;
                };
            }
        }
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
                textBox3.Clear();
                Process.Start(Output);
            }         

        }
        private void btnCsharp_Click(object sender, EventArgs e)
        {
            ConvertCSharp();
            MakeColorCSharp();           
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
            string a = "\".*\"";
            ChangeColorPat(a, Color.OrangeRed); // đổi màu các chuỗi
                     
        }
        private void MakeColorCPp()
        {
            string[] blue = { "using", "float", "public", "static", "void", "int", "string", "bool", "namespace", "cout", "cin" };
            string[] pink = { "if", "else", "return" };
            for (int i = 0; i < blue.Length; i++)
            {
                ChangeColor(blue[i], Color.Blue);
            }
            for (int i = 0; i < pink.Length; i++)
            {
                ChangeColor(pink[i], Color.Violet);
            }            
            ChangeColor("#include<iostream>", Color.Green);
            ChangeColor("std", Color.Green);
            string a = "\".*\"";
            ChangeColorPat(a, Color.OrangeRed); // đổi màu các chuỗi

        }
        private void btnCpp_Click(object sender, EventArgs e)
        {
            ConvertCPP();
            MakeColorCPp();
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
            try
            {
                string result;
                CPp file = new CPp();
                result = file.formNhap() + file.formXuat() + file.formCheck(doRegex.cutPre(rtxInput.Text)) + file.formFunction() + file.formMain(); // make form C++
                result = Regex.Replace(result, @"name", getName());  // replace name 
                result = Regex.Replace(result, @"reftype", getRequestPp("reftype")); // replace reftype C++
                result = Regex.Replace(result, @"type", getRequestPp("type")); // replace type 
                result = Regex.Replace(result, @"nonType", getRequestPp("nonType")); // replace nontype 
                result = Regex.Replace(result, @"resultType", getRequestPp("resultType")); // replace kiểu của kết quả
                result = Regex.Replace(result, @"resultName", getRequestPp("resultName")); // replacel kiểu value khi khai báo
                result = Regex.Replace(result, @"result", getRequestPp("result"));// replace tên biến kết quả
                result = Regex.Replace(result, @"intro", getRequestPp("intro")); // replace khai báo trong hàm main
                result = Regex.Replace(result, @"nhaphere", getRequestPp("nhaphere")); // replace nhập 
                result = Regex.Replace(result, @"post", getFunction(1)); // replace post 
                rtxOutput.Text = Regex.Replace(file.Result, @"x:R", result);
            }
            catch(Exception)
            {
                MessageBox.Show("Chưa có dữ liệu", "Lưu Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ConvertCSharp()
        {
            try // xử lý thay đôit cho form định sẵn
            {
                string result;
                CSharp file = new CSharp();
                result = file.formNhap() + file.formXuat() + file.formCheck(doRegex.cutPre(rtxInput.Text)) + file.formFunction() + file.formMain(); // make form C#
                result = Regex.Replace(result, @"name", getName());  // replace name 
                result = Regex.Replace(result, @"reftype", getRequestSharp("reftype")); // replace ref type
                result = Regex.Replace(result, @"nonrefType", getRequestSharp("nonrefType")); // replace non ref type
                result = Regex.Replace(result, @"type", getRequestSharp("type")); // replace type 
                result = Regex.Replace(result, @"nonType", getRequestSharp("nonType")); // replace nontype 
                result = Regex.Replace(result, @"resultType", getRequestSharp("resultType")); // replace kiểu của kết quả
                result = Regex.Replace(result, @"resultName", getRequestSharp("resultName")); // replacel kiểu value khi khai báo
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
        private string getFunction(int x = 0)
        {
            int k=3;
            if (x == 1)
                k = 0;
            string result = "";
            List<string[]> list = doRegex.doPost(doRegex.cutPost(rtxInput.Text)); // lưu danh sách các cụm kết quả đc cắt
            foreach(string[] item in list)
            {
                result += "else if(";
                for(int i=1;i<item.Length;i++)
                {
                    result += item[i] + " && ";
                }
                result = result.Remove(result.Length - 4); // xoá dấu && cuối
                result += ")" +
                    doRegex.tab(x+k)+"{" +
                    doRegex.tab(x+k+1) + item[0]+";"+
                    doRegex.tab(x+k) +"}" +
                    doRegex.tab(x+k) ;
            }
            result = result.Remove(0, 5);// xoá else đầu
            result = Regex.Replace(result, @"FALSE", "false");
            result = Regex.Replace(result, @"TRUE", "true");
            return result;
        } // dùng cho cả 2 C++ C#
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
            else if (s == "type")
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
            else if (s == "result")
            {
                string[] tmp = doRegex.doMain(doRegex.cutMain(rtxInput.Text));
                Var kq = new Var(tmp[tmp.Length - 1]);               
                result = kq.Type + " " + kq.Name + " = " + kq.Value;
            }
            else if (s == "resultType")
            {
                string[] tmp = doRegex.doMain(doRegex.cutMain(rtxInput.Text));
                result = new Var(tmp[tmp.Length - 1]).Type;
            }
            else if (s == "resultName")
            {
                string[] tmp = doRegex.doMain(doRegex.cutMain(rtxInput.Text));
                result = new Var(tmp[tmp.Length - 1]).Name;
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
                    result += item.Type + " " + item.Name + " = " + item.Value + ";" + doRegex.tab(3);
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
                foreach (Var item in Variables)
                {
                    if (item.Type == "float[]" || item.Type == "int[]") // nếu là mảng 
                    {
                        result += "Console.Write(\"Moi nhap so phan tu: \");" +
                                doRegex.tab(3) + "n = " + "type.Parse(Console.ReadLine());" +
                                doRegex.tab(3) + item.Name + " = new " + doRegex.Arr(item.Type) + "[n];";
                        result += doRegex.tab(3) + "for (int i = 0; i < n; i++)" +
                                doRegex.tab(3) + "{" +
                                doRegex.tab(4) + "Console.Write(\"Nhap phan tu thu {0}: \",i+1);" +
                                doRegex.tab(4) + item.Name + "[i] = " + doRegex.Arr(item.Type) + ".Parse(Console.ReadLine());" +
                                doRegex.tab(3) + "}";
                        result = Regex.Replace(result, @"type", new Var(tmp[tmp.Length - 2]).Type);
                        return result;
                    }
                    else // biến thường 
                    {
                        result += doRegex.tab(3) + "Console.Write(\"Moi nhap " + item.Name + " : \");" +
                                 doRegex.tab(3) + item.Name + " = " + item.Type + ".Parse(Console.ReadLine());";

                    }

                }

            }
            return result;
        }
        private string getRequestPp(string s)
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
                    if (item.Type == "float[]" || item.Type == "int[]")
                        result += doRegex.Arr(item.Type) +" "+ item.Name + "[],";
                    else result += item.Type + "  &" + item.Name + ",";
                }
                result = result.Remove(result.Length - 1); // xoá dấu phẩy cuối
            }
            else if (s == "type")
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
            else if (s == "result")
            {
                string[] tmp = doRegex.doMain(doRegex.cutMain(rtxInput.Text));
                Var kq = new Var(tmp[tmp.Length - 1]);             
                result = kq.Type + " " + kq.Name + " = " + kq.Value;
            }
            else if (s == "resultType")
            {
                string[] tmp = doRegex.doMain(doRegex.cutMain(rtxInput.Text));
                result = new Var(tmp[tmp.Length - 1]).Type;
            }
            else if (s == "resultName")
            {
                string[] tmp = doRegex.doMain(doRegex.cutMain(rtxInput.Text));
                result = new Var(tmp[tmp.Length - 1]).Name;
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
                    if (item.Type == "float[]" || item.Type == "int[]")
                        result += doRegex.Arr(item.Type) + " " + item.Name + "[0];"+ doRegex.tab(1);  // mặc định lúc khởi tạo mảng int hay flaot đều 0 phần tử
                    else
                        result += item.Type + " " + item.Name + " = " + item.Value + ";" + doRegex.tab(1);
                }
                result = result.Remove(result.Length - 2); // xoá dấu \n tab cuối
            }
            else if (s == "nhaphere")
            {
                string[] tmp = doRegex.doMain(doRegex.cutMain(rtxInput.Text)); // một mảng chuỗi đc cắt của dòng main(khai báo)
                for (int i = 1; i < tmp.Length - 1; i++)
                {
                    Variables.Add(new Var(tmp[i]));
                }
                foreach (Var item in Variables)
                {
                    if (item.Type == "float[]" || item.Type == "int[]") // nếu là mảng 
                    {
                        result += "cout << \"Moi nhap so phan tu: \";" +
                                doRegex.tab(1) + "cin >> n;" +
                                doRegex.tab(1) + doRegex.Arr(item.Type) + " "+ item.Name+"[]"+" =  " +item.Value;
                        result += doRegex.tab(1) + "for (int i = 0; i < n; i++)" +
                                doRegex.tab(1) + "{" +
                                doRegex.tab(2) + "cout<<\"Nhap phan tu thu \" << i+1;" +
                                doRegex.tab(2) + "cin >> " +item.Name + "[i];" +
                                doRegex.tab(1) + "}";
                        return result;
                    }
                    else // biến thường 
                    {
                        result += doRegex.tab(1) + "cout << \"Moi nhap \" << " + item.Name + ";" +
                                 doRegex.tab(1) + "cin >> " + item.Name + ";";

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
