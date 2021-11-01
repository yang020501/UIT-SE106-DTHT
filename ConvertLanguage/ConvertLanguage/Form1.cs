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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(openFile.FileName);
                rtxInput.Text = read.ReadToEnd();
                read.Close();
                clearSpace(rtxInput.Text);
            }
            
        }

        private void clearSpace(string text)
        {
            text.Trim();
            while (text.Contains("  "))
                text = text.Replace("  "," ");
            rtxInput.Text = text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFile.ShowDialog();
        }
       
    }
}
