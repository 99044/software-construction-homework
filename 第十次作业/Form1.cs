using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            string query = textBoxQuery.Text;
            textBoxSogouResults.Text = "Searching...";
            textBoxBingResults.Text = "Searching...";

            string sogouResults = await SearchEngineAsync("sogou", query);
            string bingResults = await SearchEngineAsync("bing", query);

            textBoxSogouResults.Text = sogouResults;
            textBoxBingResults.Text = bingResults;
        }
        
        private async Task<string> SearchEngineAsync(string engine, string query)
        {
            string url = (string.Equals(engine,"sogou")) ? $"https://www.sogou.com/web?query={query}" : $"https://www.bing.com/search?q={query}";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            HttpResponseMessage response = await client.GetAsync(url);
            string html = await response.Content.ReadAsStringAsync();

            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            
            string text = "";
            var results = doc.DocumentNode.SelectNodes("//p[@class='txt-info']");
            switch (engine)
            {
                case "sogou":
                    results = doc.DocumentNode.SelectNodes("//p");
                    if (results != null)
                    {
                        foreach (var result in results)
                        {
                            text += result.InnerText.Trim() + "\n";
                            if (text.Length > 200) break;
                        }
                    }
                    else
                    {
                        return "false";
                    }
                    break;
                case "bing":
                    results = doc.DocumentNode.SelectNodes("//p");
                    if (results != null)
                    {
                        foreach (var result in results)
                        {
                            text += result.InnerText.Trim() + "\n";
                            if (text.Length > 200) break;
                        }
                    }
                    break;
            }
            
            // if (engine == "sogou")
            // {
            //     var results = doc.DocumentNode.SelectNodes("//p[@class='txt-info']");
            //     if (results != null)
            //     {
            //         foreach (var result in results)
            //         {
            //             text += result.InnerText.Trim() + "\n";
            //             if (text.Length > 200) break;
            //         }
            //     }
            //     else
            //     {
            //         return "false";
            //     }
            // }
            // else if (engine == "bing")
            // {
            //     var results = doc.DocumentNode.SelectNodes("//p");
            //     if (results != null)
            //     {
            //         foreach (var result in results)
            //         {
            //             text += result.InnerText.Trim() + "\n";
            //             if (text.Length > 200) break;
            //         }
            //     }
            // }

            return text.Length > 200 ? text.Substring(0, 200) : text;
        }


        
    }
}