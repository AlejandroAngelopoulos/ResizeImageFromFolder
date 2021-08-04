using System.Windows.Forms;


namespace ResizeImageFromFolder
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
            this.txtTF = new System.Windows.Forms.TextBox();
            this.txtSF = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtW = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBarControl1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // txtTF
            // 
            this.txtTF.Location = new System.Drawing.Point(131, 95);
            this.txtTF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTF.Name = "txtTF";
            this.txtTF.Size = new System.Drawing.Size(425, 22);
            this.txtTF.TabIndex = 0;
            // 
            // txtSF
            // 
            this.txtSF.Location = new System.Drawing.Point(131, 53);
            this.txtSF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSF.Name = "txtSF";
            this.txtSF.Size = new System.Drawing.Size(425, 22);
            this.txtSF.TabIndex = 1;
            // 
            // txtH
            // 
            this.txtH.BackColor = System.Drawing.Color.White;
            this.txtH.Enabled = false;
            this.txtH.Location = new System.Drawing.Point(404, 160);
            this.txtH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(100, 22);
            this.txtH.TabIndex = 2;
            // 
            // txtW
            // 
            this.txtW.Location = new System.Drawing.Point(197, 160);
            this.txtW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(100, 22);
            this.txtW.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(592, 53);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(592, 95);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(276, 197);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 46);
            this.button3.TabIndex = 6;
            this.button3.Text = "Resize and Save to folder";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "To Folder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Width ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Height";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(131, 273);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Size = new System.Drawing.Size(425, 23);
            this.progressBarControl1.Step = 1;
            this.progressBarControl1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarControl1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 316);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtW);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.txtSF);
            this.Controls.Add(this.txtTF);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtTF;
        private TextBox txtSF;
        private TextBox txtH;
        private TextBox txtW;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ProgressBar progressBarControl1;
    }
}

