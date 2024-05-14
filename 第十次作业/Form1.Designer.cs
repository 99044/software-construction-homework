namespace WindowsFormsApp7
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxBingResults = new System.Windows.Forms.TextBox();
            this.textBoxQuery = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSogouResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(744, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 140);
            this.button1.TabIndex = 0;
            this.button1.Text = "点击查找";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxBingResults
            // 
            this.textBoxBingResults.Location = new System.Drawing.Point(98, 522);
            this.textBoxBingResults.Multiline = true;
            this.textBoxBingResults.Name = "textBoxBingResults";
            this.textBoxBingResults.Size = new System.Drawing.Size(941, 249);
            this.textBoxBingResults.TabIndex = 2;
            // 
            // textBoxQuery
            // 
            this.textBoxQuery.Location = new System.Drawing.Point(98, 47);
            this.textBoxQuery.Multiline = true;
            this.textBoxQuery.Name = "textBoxQuery";
            this.textBoxQuery.Size = new System.Drawing.Size(587, 140);
            this.textBoxQuery.TabIndex = 3;
            this.textBoxQuery.Text = "请输入要查询的内容";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(98, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bing搜索引擎";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(98, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sogou搜索引擎";
            // 
            // textBoxSogouResults
            // 
            this.textBoxSogouResults.Location = new System.Drawing.Point(98, 230);
            this.textBoxSogouResults.Multiline = true;
            this.textBoxSogouResults.Name = "textBoxSogouResults";
            this.textBoxSogouResults.Size = new System.Drawing.Size(941, 263);
            this.textBoxSogouResults.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 816);
            this.Controls.Add(this.textBoxSogouResults);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxQuery);
            this.Controls.Add(this.textBoxBingResults);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxSogouResults;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox textBoxQuery;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxBingResults;

        #endregion
    }
}