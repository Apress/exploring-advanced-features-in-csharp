namespace AsyncExample
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblLinesRead = new System.Windows.Forms.Label();
            this.btnReadBigFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCompletedLineCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lines read:";
            // 
            // lblLinesRead
            // 
            this.lblLinesRead.AutoSize = true;
            this.lblLinesRead.Location = new System.Drawing.Point(86, 46);
            this.lblLinesRead.Name = "lblLinesRead";
            this.lblLinesRead.Size = new System.Drawing.Size(68, 13);
            this.lblLinesRead.TabIndex = 1;
            this.lblLinesRead.Text = "lblLinesRead";
            // 
            // btnReadBigFile
            // 
            this.btnReadBigFile.Location = new System.Drawing.Point(15, 84);
            this.btnReadBigFile.Name = "btnReadBigFile";
            this.btnReadBigFile.Size = new System.Drawing.Size(86, 23);
            this.btnReadBigFile.TabIndex = 2;
            this.btnReadBigFile.Text = "Read Big File";
            this.btnReadBigFile.UseVisualStyleBackColor = true;
            this.btnReadBigFile.Click += new System.EventHandler(this.btnReadBigFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Line Count:";
            // 
            // lblCompletedLineCount
            // 
            this.lblCompletedLineCount.AutoSize = true;
            this.lblCompletedLineCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletedLineCount.Location = new System.Drawing.Point(141, 146);
            this.lblCompletedLineCount.Name = "lblCompletedLineCount";
            this.lblCompletedLineCount.Size = new System.Drawing.Size(239, 26);
            this.lblCompletedLineCount.TabIndex = 4;
            this.lblCompletedLineCount.Text = "lblCompletedLineCount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 215);
            this.Controls.Add(this.lblCompletedLineCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReadBigFile);
            this.Controls.Add(this.lblLinesRead);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Responsive Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLinesRead;
        private System.Windows.Forms.Button btnReadBigFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCompletedLineCount;
    }
}

