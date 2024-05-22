namespace WindowsFormsApp8
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
            this.labelChinese = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxEnglish = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelChinese
            // 
            this.labelChinese.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelChinese.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelChinese.Font = new System.Drawing.Font("宋体", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelChinese.Location = new System.Drawing.Point(275, 392);
            this.labelChinese.Name = "labelChinese";
            this.labelChinese.Size = new System.Drawing.Size(251, 95);
            this.labelChinese.TabIndex = 0;
            this.labelChinese.Text = "word";
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.next.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.next.Font = new System.Drawing.Font("宋体", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.next.Location = new System.Drawing.Point(275, 581);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(251, 95);
            this.next.TabIndex = 1;
            this.next.Text = "next";
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // labelResult
            // 
            this.labelResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelResult.Font = new System.Drawing.Font("宋体", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelResult.Location = new System.Drawing.Point(591, 581);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(269, 95);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "submit";
            this.labelResult.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBoxEnglish
            // 
            this.textBoxEnglish.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxEnglish.Font = new System.Drawing.Font("宋体", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxEnglish.Location = new System.Drawing.Point(275, 193);
            this.textBoxEnglish.Multiline = true;
            this.textBoxEnglish.Name = "textBoxEnglish";
            this.textBoxEnglish.Size = new System.Drawing.Size(585, 106);
            this.textBoxEnglish.TabIndex = 3;
            this.textBoxEnglish.Text = "enter";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("宋体", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(591, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 95);
            this.label1.TabIndex = 4;
            this.label1.Text = "result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 907);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEnglish);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.next);
            this.Controls.Add(this.labelChinese);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label labelChinese;
        private System.Windows.Forms.TextBox textBoxEnglish;

        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label next;

        #endregion
    }
}