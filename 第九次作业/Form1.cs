using System;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
            private void btnScrape_Click(object sender, EventArgs e)
            {
                string url = txtURL.Text;

                // 使用 WebClient 获取页面内容
                using (WebClient client = new WebClient())
                {
                    try
                    {
                        string html = client.DownloadString(url);

                        // 使用正则表达式查找手机号码
                        Regex phoneRegex = new Regex(@"1[3456789]\d{9}");
                        MatchCollection phoneMatches = phoneRegex.Matches(html);

                        // 使用正则表达式查找邮箱地址
                        Regex emailRegex = new Regex(@"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}");
                        MatchCollection emailMatches = emailRegex.Matches(html);

                        // 清空文本框中的内容
                        txtResult.Text = "";

                        // 显示找到的手机号码
                        foreach (Match match in phoneMatches)
                        {
                            txtResult.AppendText("Phone: " + match.Value + Environment.NewLine);
                        }

                        // 显示找到的邮箱地址
                        foreach (Match match in emailMatches)
                        {
                            txtResult.AppendText("Email: " + match.Value + Environment.NewLine);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        
        
    }
