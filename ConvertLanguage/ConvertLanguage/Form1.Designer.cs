
namespace ConvertLanguage
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btniconOpen = new System.Windows.Forms.ToolStripButton();
            this.btniconSave = new System.Windows.Forms.ToolStripButton();
            this.btniconNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btniconBuild = new System.Windows.Forms.ToolStripButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.rtxInput = new System.Windows.Forms.RichTextBox();
            this.rtxOutput = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCpp = new System.Windows.Forms.Button();
            this.btnCsharp = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1147, 624);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.toolStrip1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1141, 57);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1141, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.openToolStripMenuItem.Text = "Open file";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btniconOpen,
            this.btniconSave,
            this.btniconNew,
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.btniconBuild});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1141, 29);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btniconOpen
            // 
            this.btniconOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btniconOpen.Image = ((System.Drawing.Image)(resources.GetObject("btniconOpen.Image")));
            this.btniconOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btniconOpen.Name = "btniconOpen";
            this.btniconOpen.Size = new System.Drawing.Size(29, 26);
            this.btniconOpen.Text = "Open";
            this.btniconOpen.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // btniconSave
            // 
            this.btniconSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btniconSave.Image = ((System.Drawing.Image)(resources.GetObject("btniconSave.Image")));
            this.btniconSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btniconSave.Name = "btniconSave";
            this.btniconSave.Size = new System.Drawing.Size(29, 26);
            this.btniconSave.Text = "Save";
            this.btniconSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btniconNew
            // 
            this.btniconNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btniconNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btniconNew.Image = ((System.Drawing.Image)(resources.GetObject("btniconNew.Image")));
            this.btniconNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btniconNew.Name = "btniconNew";
            this.btniconNew.Size = new System.Drawing.Size(29, 26);
            this.btniconNew.Text = "New";
            this.btniconNew.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ActiveLinkColor = System.Drawing.SystemColors.Control;
            this.toolStripLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(27, 26);
            this.toolStripLabel1.Text = "C#";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripLabel2.ImageTransparentColor = System.Drawing.Color.Violet;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(38, 26);
            this.toolStripLabel2.Text = "C++";
            // 
            // btniconBuild
            // 
            this.btniconBuild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btniconBuild.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btniconBuild.Image = ((System.Drawing.Image)(resources.GetObject("btniconBuild.Image")));
            this.btniconBuild.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btniconBuild.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btniconBuild.Name = "btniconBuild";
            this.btniconBuild.Size = new System.Drawing.Size(29, 26);
            this.btniconBuild.Text = "Build";
            this.btniconBuild.Click += new System.EventHandler(this.btniconBuild_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 66);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1141, 555);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.81633F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.163265F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.02041F));
            this.tableLayoutPanel3.Controls.Add(this.rtxInput, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.rtxOutput, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1138, 515);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // rtxInput
            // 
            this.rtxInput.BackColor = System.Drawing.SystemColors.Control;
            this.rtxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxInput.Location = new System.Drawing.Point(3, 3);
            this.rtxInput.Name = "rtxInput";
            this.rtxInput.Size = new System.Drawing.Size(412, 509);
            this.rtxInput.TabIndex = 0;
            this.rtxInput.Text = "";
            this.rtxInput.WordWrap = false;
            // 
            // rtxOutput
            // 
            this.rtxOutput.BackColor = System.Drawing.SystemColors.Control;
            this.rtxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxOutput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rtxOutput.Location = new System.Drawing.Point(525, 3);
            this.rtxOutput.Name = "rtxOutput";
            this.rtxOutput.ReadOnly = true;
            this.rtxOutput.Size = new System.Drawing.Size(613, 509);
            this.rtxOutput.TabIndex = 1;
            this.rtxOutput.Text = "";
            this.rtxOutput.WordWrap = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnCpp);
            this.flowLayoutPanel2.Controls.Add(this.btnCsharp);
            this.flowLayoutPanel2.Controls.Add(this.textBox2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(421, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(98, 509);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // btnCpp
            // 
            this.btnCpp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCpp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCpp.BackgroundImage")));
            this.btnCpp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCpp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCpp.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnCpp.Location = new System.Drawing.Point(6, 180);
            this.btnCpp.Margin = new System.Windows.Forms.Padding(6, 180, 6, 3);
            this.btnCpp.Name = "btnCpp";
            this.btnCpp.Size = new System.Drawing.Size(79, 58);
            this.btnCpp.TabIndex = 10;
            this.btnCpp.UseVisualStyleBackColor = false;
            this.btnCpp.Click += new System.EventHandler(this.btnCpp_Click);
            // 
            // btnCsharp
            // 
            this.btnCsharp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCsharp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCsharp.BackgroundImage")));
            this.btnCsharp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCsharp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCsharp.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnCsharp.Location = new System.Drawing.Point(6, 244);
            this.btnCsharp.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnCsharp.Name = "btnCsharp";
            this.btnCsharp.Size = new System.Drawing.Size(79, 58);
            this.btnCsharp.TabIndex = 9;
            this.btnCsharp.UseVisualStyleBackColor = false;
            this.btnCsharp.Click += new System.EventHandler(this.btnCsharp_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1, 308);
            this.textBox2.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(97, 22);
            this.textBox2.TabIndex = 11;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.17949F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.82051F));
            this.tableLayoutPanel5.Controls.Add(this.btnClear, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBox3, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 518);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1138, 29);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClear.Location = new System.Drawing.Point(3, 0);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 26);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.ForeColor = System.Drawing.Color.Red;
            this.textBox3.Location = new System.Drawing.Point(558, 3);
            this.textBox3.Margin = new System.Windows.Forms.Padding(420, 3, 3, 3);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(577, 23);
            this.textBox3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 624);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "ConvertLanguage";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.RichTextBox rtxInput;
        private System.Windows.Forms.RichTextBox rtxOutput;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnCsharp;
        private System.Windows.Forms.Button btnCpp;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btniconOpen;
        private System.Windows.Forms.ToolStripButton btniconSave;
        private System.Windows.Forms.ToolStripButton btniconNew;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btniconBuild;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox textBox3;
    }
}

