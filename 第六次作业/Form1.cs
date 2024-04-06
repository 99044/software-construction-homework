using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //定义两个文件的路径
        private string filePath1 = null;
        private string filePath2 = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)//定义选择第一个文件的按钮槽函数
        {

            try
            {   //将第一个文件的路径赋值为选择的文件路径
                filePath1 = SelectFile();
                //获得文件类型（扩展名）
                string extension1 = Path.GetExtension(filePath1).ToLower();
                if (!string.IsNullOrEmpty(filePath1) && extension1 == ".txt")
                {
                    //文件非空且为.txt则成功选择
                    textBox1.Text = "File 1 selected: " + filePath1;
                }
                else
                {
                    //否则报错
                    textBox1.Text = "Only can select a txt document.";
                }
            }
            catch (Exception)
            {
                //当点击按钮但未选择文件时需catch，这里不做处理
            }
        }


        private void BtnSelectDocument2_Click(object sender, EventArgs e)//定义选择第二个文件的按钮槽函数
        {

            try
            {
                //将第二个文件的路径赋值为选择的文件路径
                filePath2 = SelectFile();
                //获得文件类型（扩展名）
                string extension2 = Path.GetExtension(filePath2).ToLower();
                if (!string.IsNullOrEmpty(filePath2) && extension2 == ".txt")
                {
                    //文件非空且为.txt则成功选择
                    textBox2.Text = "File 2 selected: " + filePath2;
                }
                else
                {
                    //否则报错
                    textBox2.Text = "Only can select a txt document.";
                }
            }
            catch (Exception)
            {
                //当点击按钮但未选择文件时需catch，这里不做处理
            }
        }

        private string SelectFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())//打开windows资源管理器
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName;
                }
            }
            return null;
        }

        

        private void document_combine_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filePath1) && !string.IsNullOrEmpty(filePath2))//两个文件名都指向对应文件
            {
                try
                {
                    //检查 Data 子目录是否存在于应用程序的启动目录中。
                    string dataDir = Path.Combine(Application.StartupPath, "Data");
                    if (!Directory.Exists(dataDir))
                    {
                        //如果不存在，创建这个目录。
                        Directory.CreateDirectory(dataDir);
                    }
                    //在Data文件夹下生成MergedFile.txt
                    string mergedFilePath = Path.Combine(dataDir, "MergedFile.txt");
                    File.WriteAllText(mergedFilePath, File.ReadAllText(filePath1) + File.ReadAllText(filePath2));
                    //文本显示成功和文件路径
                    textBox3.Text = "Files merged successfully: " + mergedFilePath;
                }
                catch (Exception ex)
                {
                    textBox3.Text = "Error: " + ex.Message;//
                }
            }
            else
            {
                textBox3.Text = "Please select both files first.";
            }
        }

    }
}