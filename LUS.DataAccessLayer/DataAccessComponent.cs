using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUS.DataAccessLayer
{
    public class DataAccessComponent

    {
        Dictionary<string, string> dict;
        public string Path { get; set; }
        public FileSystemWatcher watcher;
        public DataAccessComponent(string path, Dictionary<string, string> dict)
        {
            this.Path = path;
            watcher = new FileSystemWatcher();
            watcher.Path = path;
            this.dict=dict;
        }

        public void StartWatching()
        {

            //DirectoryInfo d = new DirectoryInfo(@"C:\Users\Alchemy.DESKTOP-V8A10HM\Desktop");
            //FileInfo[] Files = d.GetFiles("*.cs");
            //foreach (FileInfo file in Files)
            //{
            //    file.CopyTo(Path+file.Name);
            //}
            watcher.IncludeSubdirectories = true;
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
           | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            // Only watch text files.
            watcher.Filter = "*.txt";

            // Add event handlers.
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnCreated);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);
           
            watcher.EnableRaisingEvents = true;
        }
        
        // Define the event handlers.
        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            var c = e.ChangeType;
            // Specify what is done when a file is changed, created, or deleted.
            Console.WriteLine("File: " + e.FullPath + " " + e.Name);


        }

        private static void OnRenamed(object source, RenamedEventArgs e)
        {
            // Specify what is done when a file is renamed.
            Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);
        }


        private void OnCreated(object source, FileSystemEventArgs e)
        {
            //  Console.WriteLine("Hello");
           // string [] str=new string[5];
            string str = "";

            //byte[] bytes = Encoding.ASCII.GetBytes(str);
            //f2.Write(bytes, 0, bytes.Length);


            // Write the new text in a temporary file:
           // str[0] = (char)
           str += "/*\n";


            foreach (var item in dict)
            {
                //Console.WriteLine(item.Key);
                //Console.WriteLine(item.Value);
                str += item.Key  + item.Value + "\r\n";
                //File.WriteAllLines(e.FullPath, str);
              
            }
            str += "*/\n";
            File.WriteAllText(e.FullPath, str);
            // Specify what is done when a file is renamed.
            //Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);

        }


        //string currentDateAndTime;
        //string userName;
        //public string GetTime()
        //{
        //    //string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        //    currentDateAndTime = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        //    //MessageBox.Show(userName + date);
        //    return currentDateAndTime;
        //}

        //public string GetUserName()
        //{
        //    userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        //    //string currentDateAndTime = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        //    //MessageBox.Show(userName + date);
        //    return userName;
        //}

        //public void UpdateFile(string path)
        //{
        //    StreamWriter writer = new StreamWriter(path);
        //    //writer.WriteLine(Environment.NewLine + );
        //    List<string> quotelist = File.ReadAllLines(path).ToList();
        //}

    }
}
