using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
       
        private void btnCsharp_Click(object sender, EventArgs e)
        {
            ConvertCSharp();
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
            string result;
            CSharp file = new CSharp();
            result = file.formNhap() + file.formXuat() + file.formCheck(doRegex.cutPre(rtxInput.Text)) + file.formFunction() + file.formMain();

            rtxOutput.Text = Regex.Replace(file.Result, @"x:R",result );
        }

        
    }
}
