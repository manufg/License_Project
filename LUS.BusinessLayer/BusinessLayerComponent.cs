using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LUS.DataAccessLayer;

namespace LUS.BusinessLayer
{
    public class BusinessLayerComponent
    {
        Dictionary<string, string> dict;
        DataAccessComponent dataAccessComponent;
        public string Path { get; set; }
        public BusinessLayerComponent(string path)
        {
            this.Path = path;
            SplitHeader();
            dataAccessComponent = new DataAccessComponent(path,dict);
        }
        public void StartWatching()
        {
            dataAccessComponent.StartWatching();
        }
        public void SplitHeader()
        {
            //FileStream f1 = new FileStream(@"D:\siemens_project_work\14 sep\header.txt", FileMode.Open);
            //StreamReader s = new StreamReader(f1);
            //string s1 = s.ReadToEnd();
            //int pos = s1.IndexOf("/*");
            //int pos1 = s1.IndexOf("*/");

            //s1 = s1.Substring(pos, pos1);
            //s1 = s1.Replace("/*", "");
            //s1 = s1.Replace("*/", "");
            //s1.Trim();
            //int pos2 = s1.IndexOf("Author");

            //s1 = s1.Substring(pos2);
            // Console.WriteLine(s1);
            // string[] a = s1.Split(new Char[] { ':' });
            //int i = 0;
            dict = new Dictionary<string, string>();
            //for (int j = 0; j < a.Length; j += 2)
            //{
            //    dict.Add(a[j].Trim(), a[j + 1].Trim());
            //    Console.WriteLine(i++ + " " + a[j].Trim() + a[j + 1]);
            //}
            //foreach (var item in a)
            //{
            //    dict.Add(item.Trim(), "");
            //    Console.WriteLine(i++ + " " + item.Trim());
            //}
            string userName = ":"+System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string currentDateAndTime =":" +DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            string[] container = File.ReadAllLines(@"D:\License_Project\files\header.txt");
            string author, mod_date;
            // string first = "/*";
            // string lsat = "*/";
            //  author = container[0] + userName;
            // mod_date = container[1] + currentDateAndTime;
            // dict[container[0]] = first;
            dict[container[0]] = " ";
            dict[container[1]] = " ";
            dict[container[2]] = " ";
            dict[container[3]] = userName;
            dict[container[4]] = currentDateAndTime;
            dict[container[5]] = " ";

            //  dict[container[3]] = last;





            //Console.WriteLine(dict.ContainsKey("Author"));

            //dict["Last Modified By"] = userName;
            //dict["Last Modified Date"] = currentDateAndTime;

            //foreach (var item in dict)
            //{
            //    Console.WriteLine(item.Key);
            //    Console.WriteLine(item.Value);
            //}
            // s.Close();
            //f1.Close();
        }
    }
}
