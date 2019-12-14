namespace PDFSplit
{
    partial class PDFSplit
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
            this.textBoxSelectPDF = new System.Windows.Forms.TextBox();
            this.buttonSelectPDF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRange2 = new System.Windows.Forms.TextBox();
            this.textBoxRange1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.buttonLocation = new System.Windows.Forms.Button();
            this.buttonSplit = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxSelectPDF
            // 
            this.textBoxSelectPDF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSelectPDF.Location = new System.Drawing.Point(93, 14);
            this.textBoxSelectPDF.Name = "textBoxSelectPDF";
            this.textBoxSelectPDF.Size = new System.Drawing.Size(200, 20);
            this.textBoxSelectPDF.TabIndex = 0;
            // 
            // buttonSelectPDF
            // 
            this.buttonSelectPDF.Location = new System.Drawing.Point(12, 12);
            this.buttonSelectPDF.Name = "buttonSelectPDF";
            this.buttonSelectPDF.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectPDF.TabIndex = 1;
            this.buttonSelectPDF.Text = "Select PDF";
            this.buttonSelectPDF.UseVisualStyleBackColor = true;
            this.buttonSelectPDF.Click += new System.EventHandler(this.buttonSelectPDF_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Page Range:";
            // 
            // textBoxRange2
            // 
            this.textBoxRange2.Location = new System.Drawing.Point(165, 40);
            this.textBoxRange2.Name = "textBoxRange2";
            this.textBoxRange2.Size = new System.Drawing.Size(50, 20);
            this.textBoxRange2.TabIndex = 3;
            this.textBoxRange2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRange2_KeyPress);
            // 
            // textBoxRange1
            // 
            this.textBoxRange1.Location = new System.Drawing.Point(93, 40);
            this.textBoxRange1.Name = "textBoxRange1";
            this.textBoxRange1.Size = new System.Drawing.Size(50, 20);
            this.textBoxRange1.TabIndex = 4;
            this.textBoxRange1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRange1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "-";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLocation.Location = new System.Drawing.Point(93, 66);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(200, 20);
            this.textBoxLocation.TabIndex = 6;
            // 
            // buttonLocation
            // 
            this.buttonLocation.Location = new System.Drawing.Point(12, 64);
            this.buttonLocation.Name = "buttonLocation";
            this.buttonLocation.Size = new System.Drawing.Size(75, 23);
            this.buttonLocation.TabIndex = 7;
            this.buttonLocation.Text = "Location";
            this.buttonLocation.UseVisualStyleBackColor = true;
            this.buttonLocation.Click += new System.EventHandler(this.buttonLocation_Click);
            // 
            // buttonSplit
            // 
            this.buttonSplit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSplit.Location = new System.Drawing.Point(218, 92);
            this.buttonSplit.Name = "buttonSplit";
            this.buttonSplit.Size = new System.Drawing.Size(75, 23);
            this.buttonSplit.TabIndex = 8;
            this.buttonSplit.Text = "Split";
            this.buttonSplit.UseVisualStyleBackColor = true;
            this.buttonSplit.Click += new System.EventHandler(this.buttonSplit_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(12, 92);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(200, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "github.com/onursert";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 140);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonSplit);
            this.Controls.Add(this.buttonLocation);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRange1);
            this.Controls.Add(this.textBoxRange2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSelectPDF);
            this.Controls.Add(this.textBoxSelectPDF);
            this.Name = "Form1";
            this.Text = "PDF Split";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSelectPDF;
        private System.Windows.Forms.Button buttonSelectPDF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRange2;
        private System.Windows.Forms.TextBox textBoxRange1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Button buttonLocation;
        private System.Windows.Forms.Button buttonSplit;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label3;
    }
}

