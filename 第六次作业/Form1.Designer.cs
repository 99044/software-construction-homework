namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSelectDocument1 = new Button();
            btnSelectDocument2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            document_combine = new Button();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // btnSelectDocument1
            // 
            btnSelectDocument1.Location = new Point(160, 157);
            btnSelectDocument1.Name = "btnSelectDocument1";
            btnSelectDocument1.Size = new Size(340, 68);
            btnSelectDocument1.TabIndex = 0;
            btnSelectDocument1.Text = "click to select document1";
            btnSelectDocument1.UseVisualStyleBackColor = true;
            btnSelectDocument1.Click += Button1_Click;
            // 
            // btnSelectDocument2
            // 
            btnSelectDocument2.Location = new Point(664, 157);
            btnSelectDocument2.Name = "btnSelectDocument2";
            btnSelectDocument2.Size = new Size(340, 68);
            btnSelectDocument2.TabIndex = 1;
            btnSelectDocument2.Text = "click to select document2";
            btnSelectDocument2.UseVisualStyleBackColor = true;
            btnSelectDocument2.Click += BtnSelectDocument2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(160, 278);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(340, 30);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(664, 278);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(340, 30);
            textBox2.TabIndex = 3;
            // 
            // document_combine
            // 
            document_combine.Location = new Point(428, 464);
            document_combine.Name = "document_combine";
            document_combine.Size = new Size(340, 68);
            document_combine.TabIndex = 4;
            document_combine.Text = "click to combine document";
            document_combine.UseVisualStyleBackColor = true;
            document_combine.Click += document_combine_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(124, 580);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(1014, 30);
            textBox3.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 828);
            Controls.Add(textBox3);
            Controls.Add(document_combine);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnSelectDocument2);
            Controls.Add(btnSelectDocument1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectDocument1;
        private Button btnSelectDocument2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button document_combine;
        private TextBox textBox3;
    }
}