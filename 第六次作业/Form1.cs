using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //���������ļ���·��
        private string filePath1 = null;
        private string filePath2 = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)//����ѡ���һ���ļ��İ�ť�ۺ���
        {

            try
            {   //����һ���ļ���·����ֵΪѡ����ļ�·��
                filePath1 = SelectFile();
                //����ļ����ͣ���չ����
                string extension1 = Path.GetExtension(filePath1).ToLower();
                if (!string.IsNullOrEmpty(filePath1) && extension1 == ".txt")
                {
                    //�ļ��ǿ���Ϊ.txt��ɹ�ѡ��
                    textBox1.Text = "File 1 selected: " + filePath1;
                }
                else
                {
                    //���򱨴�
                    textBox1.Text = "Only can select a txt document.";
                }
            }
            catch (Exception)
            {
                //�������ť��δѡ���ļ�ʱ��catch�����ﲻ������
            }
        }


        private void BtnSelectDocument2_Click(object sender, EventArgs e)//����ѡ��ڶ����ļ��İ�ť�ۺ���
        {

            try
            {
                //���ڶ����ļ���·����ֵΪѡ����ļ�·��
                filePath2 = SelectFile();
                //����ļ����ͣ���չ����
                string extension2 = Path.GetExtension(filePath2).ToLower();
                if (!string.IsNullOrEmpty(filePath2) && extension2 == ".txt")
                {
                    //�ļ��ǿ���Ϊ.txt��ɹ�ѡ��
                    textBox2.Text = "File 2 selected: " + filePath2;
                }
                else
                {
                    //���򱨴�
                    textBox2.Text = "Only can select a txt document.";
                }
            }
            catch (Exception)
            {
                //�������ť��δѡ���ļ�ʱ��catch�����ﲻ������
            }
        }

        private string SelectFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())//��windows��Դ������
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
            if (!string.IsNullOrEmpty(filePath1) && !string.IsNullOrEmpty(filePath2))//�����ļ�����ָ���Ӧ�ļ�
            {
                try
                {
                    //��� Data ��Ŀ¼�Ƿ������Ӧ�ó��������Ŀ¼�С�
                    string dataDir = Path.Combine(Application.StartupPath, "Data");
                    if (!Directory.Exists(dataDir))
                    {
                        //��������ڣ��������Ŀ¼��
                        Directory.CreateDirectory(dataDir);
                    }
                    //��Data�ļ���������MergedFile.txt
                    string mergedFilePath = Path.Combine(dataDir, "MergedFile.txt");
                    File.WriteAllText(mergedFilePath, File.ReadAllText(filePath1) + File.ReadAllText(filePath2));
                    //�ı���ʾ�ɹ����ļ�·��
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