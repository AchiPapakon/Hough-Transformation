namespace Hough_Transformation
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openAsGrayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findHoughTransformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.explanationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic_R_Theta = new System.Windows.Forms.PictureBox();
            this.HoughBtn = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbly = new System.Windows.Forms.Label();
            this.lblx = new System.Windows.Forms.Label();
            this.lblrmax = new System.Windows.Forms.Label();
            this.lblmrmax = new System.Windows.Forms.Label();
            this.lblmpi = new System.Windows.Forms.Label();
            this.lblpi = new System.Windows.Forms.Label();
            this.lblzero1 = new System.Windows.Forms.Label();
            this.lblzero2 = new System.Windows.Forms.Label();
            this.lblzero3 = new System.Windows.Forms.Label();
            this.progHough = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLines = new System.Windows.Forms.Button();
            this.nmrLines = new System.Windows.Forms.NumericUpDown();
            this.grpLines = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolx = new System.Windows.Forms.ToolStripStatusLabel();
            this.tooly = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolR = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_R_Theta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrLines)).BeginInit();
            this.grpLines.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = resources.GetString("openFileDialog1.Filter");
            this.openFileDialog1.FilterIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.processingToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(694, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.openAsGrayscaleToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.openToolStripMenuItem1.Text = "&Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // openAsGrayscaleToolStripMenuItem
            // 
            this.openAsGrayscaleToolStripMenuItem.Name = "openAsGrayscaleToolStripMenuItem";
            this.openAsGrayscaleToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.openAsGrayscaleToolStripMenuItem.Text = "Open As &Grayscale";
            this.openAsGrayscaleToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // processingToolStripMenuItem
            // 
            this.processingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invertToolStripMenuItem,
            this.grayscaleToolStripMenuItem,
            this.findHoughTransformationToolStripMenuItem});
            this.processingToolStripMenuItem.Enabled = false;
            this.processingToolStripMenuItem.Name = "processingToolStripMenuItem";
            this.processingToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.processingToolStripMenuItem.Text = "&Processing";
            // 
            // invertToolStripMenuItem
            // 
            this.invertToolStripMenuItem.Name = "invertToolStripMenuItem";
            this.invertToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.invertToolStripMenuItem.Text = "&Invert";
            this.invertToolStripMenuItem.Click += new System.EventHandler(this.invertToolStripMenuItem_Click);
            // 
            // grayscaleToolStripMenuItem
            // 
            this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.grayscaleToolStripMenuItem.Text = "&Grayscale";
            this.grayscaleToolStripMenuItem.Click += new System.EventHandler(this.grayscaleToolStripMenuItem_Click);
            // 
            // findHoughTransformationToolStripMenuItem
            // 
            this.findHoughTransformationToolStripMenuItem.Name = "findHoughTransformationToolStripMenuItem";
            this.findHoughTransformationToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.findHoughTransformationToolStripMenuItem.Text = "Find &Hough Transformation";
            this.findHoughTransformationToolStripMenuItem.Click += new System.EventHandler(this.findHoughTransformationToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.explanationToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // explanationToolStripMenuItem
            // 
            this.explanationToolStripMenuItem.Name = "explanationToolStripMenuItem";
            this.explanationToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.explanationToolStripMenuItem.Text = "&Explanation";
            this.explanationToolStripMenuItem.Click += new System.EventHandler(this.explanationToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.openToolStripMenuItem.Text = "Open As &Grayscale";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(32, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 480);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // pic_R_Theta
            // 
            this.pic_R_Theta.InitialImage = null;
            this.pic_R_Theta.Location = new System.Drawing.Point(726, 27);
            this.pic_R_Theta.Name = "pic_R_Theta";
            this.pic_R_Theta.Size = new System.Drawing.Size(360, 800);
            this.pic_R_Theta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_R_Theta.TabIndex = 2;
            this.pic_R_Theta.TabStop = false;
            this.pic_R_Theta.MouseLeave += new System.EventHandler(this.pic_R_Theta_MouseLeave);
            this.pic_R_Theta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_R_Theta_MouseMove);
            // 
            // HoughBtn
            // 
            this.HoughBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HoughBtn.Image = ((System.Drawing.Image)(resources.GetObject("HoughBtn.Image")));
            this.HoughBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HoughBtn.Name = "HoughBtn";
            this.HoughBtn.Size = new System.Drawing.Size(23, 22);
            this.HoughBtn.Text = "Hough Transformation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(678, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // lbly
            // 
            this.lbly.AutoSize = true;
            this.lbly.Location = new System.Drawing.Point(14, 27);
            this.lbly.Name = "lbly";
            this.lbly.Size = new System.Drawing.Size(12, 13);
            this.lbly.TabIndex = 5;
            this.lbly.Text = "y";
            this.lbly.Visible = false;
            // 
            // lblx
            // 
            this.lblx.AutoSize = true;
            this.lblx.Location = new System.Drawing.Point(660, 510);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(12, 13);
            this.lblx.TabIndex = 6;
            this.lblx.Text = "x";
            this.lblx.Visible = false;
            // 
            // lblrmax
            // 
            this.lblrmax.AutoSize = true;
            this.lblrmax.Location = new System.Drawing.Point(688, 24);
            this.lblrmax.Name = "lblrmax";
            this.lblrmax.Size = new System.Drawing.Size(32, 13);
            this.lblrmax.TabIndex = 7;
            this.lblrmax.Text = "ρmax";
            // 
            // lblmrmax
            // 
            this.lblmrmax.AutoSize = true;
            this.lblmrmax.Location = new System.Drawing.Point(685, 814);
            this.lblmrmax.Name = "lblmrmax";
            this.lblmrmax.Size = new System.Drawing.Size(38, 13);
            this.lblmrmax.TabIndex = 8;
            this.lblmrmax.Text = "- ρmax";
            // 
            // lblmpi
            // 
            this.lblmpi.AutoSize = true;
            this.lblmpi.Location = new System.Drawing.Point(723, 830);
            this.lblmpi.Name = "lblmpi";
            this.lblmpi.Size = new System.Drawing.Size(34, 13);
            this.lblmpi.TabIndex = 9;
            this.lblmpi.Text = "- 0.5π";
            // 
            // lblpi
            // 
            this.lblpi.AutoSize = true;
            this.lblpi.Location = new System.Drawing.Point(1073, 830);
            this.lblpi.Name = "lblpi";
            this.lblpi.Size = new System.Drawing.Size(13, 13);
            this.lblpi.TabIndex = 10;
            this.lblpi.Text = "π";
            // 
            // lblzero1
            // 
            this.lblzero1.AutoSize = true;
            this.lblzero1.Location = new System.Drawing.Point(14, 510);
            this.lblzero1.Name = "lblzero1";
            this.lblzero1.Size = new System.Drawing.Size(13, 13);
            this.lblzero1.TabIndex = 11;
            this.lblzero1.Text = "0";
            this.lblzero1.Visible = false;
            // 
            // lblzero2
            // 
            this.lblzero2.AutoSize = true;
            this.lblzero2.Location = new System.Drawing.Point(707, 40);
            this.lblzero2.Name = "lblzero2";
            this.lblzero2.Size = new System.Drawing.Size(25, 13);
            this.lblzero2.TabIndex = 12;
            this.lblzero2.Text = "0 ->";
            // 
            // lblzero3
            // 
            this.lblzero3.AutoSize = true;
            this.lblzero3.Location = new System.Drawing.Point(707, 53);
            this.lblzero3.Name = "lblzero3";
            this.lblzero3.Size = new System.Drawing.Size(13, 13);
            this.lblzero3.TabIndex = 13;
            this.lblzero3.Text = "0";
            // 
            // progHough
            // 
            this.progHough.Location = new System.Drawing.Point(140, 513);
            this.progHough.Maximum = 216000;
            this.progHough.Name = "progHough";
            this.progHough.Size = new System.Drawing.Size(402, 23);
            this.progHough.TabIndex = 14;
            this.progHough.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(690, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 819);
            this.panel1.TabIndex = 15;
            // 
            // btnLines
            // 
            this.btnLines.Location = new System.Drawing.Point(62, 71);
            this.btnLines.Name = "btnLines";
            this.btnLines.Size = new System.Drawing.Size(70, 23);
            this.btnLines.TabIndex = 16;
            this.btnLines.Text = "Find Lines";
            this.btnLines.UseVisualStyleBackColor = true;
            this.btnLines.Click += new System.EventHandler(this.btnLines_Click);
            // 
            // nmrLines
            // 
            this.nmrLines.Location = new System.Drawing.Point(84, 19);
            this.nmrLines.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nmrLines.Name = "nmrLines";
            this.nmrLines.Size = new System.Drawing.Size(48, 20);
            this.nmrLines.TabIndex = 17;
            this.nmrLines.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // grpLines
            // 
            this.grpLines.Controls.Add(this.label3);
            this.grpLines.Controls.Add(this.btnLines);
            this.grpLines.Controls.Add(this.nmrLines);
            this.grpLines.Location = new System.Drawing.Point(32, 542);
            this.grpLines.Name = "grpLines";
            this.grpLines.Size = new System.Drawing.Size(139, 100);
            this.grpLines.TabIndex = 18;
            this.grpLines.TabStop = false;
            this.grpLines.Text = "Find Lines";
            this.grpLines.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Set Threshold:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolx,
            this.tooly,
            this.toolR});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(694, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolx
            // 
            this.toolx.Name = "toolx";
            this.toolx.Size = new System.Drawing.Size(20, 17);
            this.toolx.Text = "X: ";
            // 
            // tooly
            // 
            this.tooly.Name = "tooly";
            this.tooly.Size = new System.Drawing.Size(20, 17);
            this.tooly.Text = "Y: ";
            // 
            // toolR
            // 
            this.toolR.Name = "toolR";
            this.toolR.Size = new System.Drawing.Size(16, 17);
            this.toolR.Text = "   ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 561);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpLines);
            this.Controls.Add(this.progHough);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblzero3);
            this.Controls.Add(this.lblzero2);
            this.Controls.Add(this.lblzero1);
            this.Controls.Add(this.lblpi);
            this.Controls.Add(this.lblmpi);
            this.Controls.Add(this.lblmrmax);
            this.Controls.Add(this.lblrmax);
            this.Controls.Add(this.lblx);
            this.Controls.Add(this.lbly);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_R_Theta);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Hough Trasformation";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_R_Theta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrLines)).EndInit();
            this.grpLines.ResumeLayout(false);
            this.grpLines.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pic_R_Theta;
        private System.Windows.Forms.ToolStripButton HoughBtn;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openAsGrayscaleToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbly;
        private System.Windows.Forms.Label lblx;
        private System.Windows.Forms.Label lblrmax;
        private System.Windows.Forms.Label lblmrmax;
        private System.Windows.Forms.Label lblmpi;
        private System.Windows.Forms.Label lblpi;
        private System.Windows.Forms.Label lblzero1;
        private System.Windows.Forms.Label lblzero2;
        private System.Windows.Forms.Label lblzero3;
        private System.Windows.Forms.ProgressBar progHough;
        private System.Windows.Forms.ToolStripMenuItem processingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findHoughTransformationToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLines;
        private System.Windows.Forms.ToolStripMenuItem invertToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown nmrLines;
        private System.Windows.Forms.GroupBox grpLines;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tooly;
        private System.Windows.Forms.ToolStripStatusLabel toolR;
        private System.Windows.Forms.ToolStripStatusLabel toolx;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem explanationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

