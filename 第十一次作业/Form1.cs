using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private MySqlConnection mysqlConn;
        private MySqlCommand mysqlCmd;
        private MySqlDataReader mysqlReader;
        private string correctEnglishWord;
        public Form1()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadNextWord();
        }
        private void InitializeDatabase()
        {
            //与数据库进行连接
            string connectionString = "server=localhost;database=vocabulary;user=root;password=minqihao123;";
            mysqlConn = new MySqlConnection(connectionString);
            mysqlConn.Open();
        }

        private void LoadNextWord()
        {
            mysqlCmd = new MySqlCommand("SELECT * FROM Words ORDER BY RAND() LIMIT 1", mysqlConn);
            mysqlReader = mysqlCmd.ExecuteReader();
            if (mysqlReader.Read())
            {
                labelChinese.Text = mysqlReader["ChineseMeaning"].ToString();
                correctEnglishWord = mysqlReader["EnglishWord"].ToString();
            }
            mysqlReader.Close();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (textBoxEnglish.Text.Trim().Equals(correctEnglishWord, StringComparison.OrdinalIgnoreCase))
            {
                label1.Text = "正确";
            }
            else
            {
                label1.Text = "错误";
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            LoadNextWord();
            textBoxEnglish.Clear();
            textBoxEnglish.Focus();
        }
    }
}
