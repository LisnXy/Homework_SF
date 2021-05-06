using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace WinFormApp {
    class SimpleCrawler {
        private Hashtable urls = new Hashtable();
        public int count = 0;
        public string target = " ";
        public List<Url> results = new List<Url>();
        public List<Url> exceptions = new List<Url>();
        public Task[] tasks = { };


    public void Crawl() {
            this.results.Clear();
            this.exceptions.Clear();
            if (urls[target] == null) urls[target] = false;      
      while (true) {
        string current = null;
        foreach (string url in urls.Keys) {
          if ((bool)urls[url]) continue;
          current = url;
        }

        if (current == null || count > 10) break;
                tasks.Append(Task.Run(() => { string html = DownLoad(current);
                    urls[current] = true;
                    this.results.Add(new Url(current));
                    count++;
                    Parse(html);
                } ));     
      }
    }

    public string DownLoad(string url) {
      try {
        WebClient webClient = new WebClient();
        webClient.Encoding = Encoding.UTF8;
        string html = webClient.DownloadString(url);
        string fileName = count.ToString();
        File.WriteAllText(fileName, html, Encoding.UTF8);
        return html;
      }
      catch (Exception ex) {
        Console.WriteLine(ex.Message);
        return "";
      }
    }

    private void Parse(string html) {
      string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
      string fliter = @"html|aspx";
      MatchCollection matches = new Regex(strRef).Matches(html);
      foreach (Match match in matches) {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                      .Trim('"', '\"', '#', '>');
                if (Regex.IsMatch(strRef, fliter))
                {
                    
                    if (strRef.Length == 0) continue;
                    if (urls[strRef] == null) urls[strRef] = false;
                }
                else
                {
                    exceptions.Add(new Url(strRef));
                }
      }
    }
  }
}
