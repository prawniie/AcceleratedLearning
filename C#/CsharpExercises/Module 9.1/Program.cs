using System;
using System.IO;

namespace Module_9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var watcher = new FileSystemWatcher();
            watcher.Path = @"C:\Testar";
            watcher.EnableRaisingEvents = true;

            watcher.Created += FileCreated;
            watcher.Changed += FileChanged;
            watcher.Deleted += FileDeleted;
            watcher.Renamed += FileRenamed;


            Console.ReadKey();
        }


        private static void FileRenamed(object sender, RenamedEventArgs e)
        {
            Console.Write($"{e.Name} is renamed!");
        }

        private static void FileCreated(object sender, FileSystemEventArgs e)
        {
            //FileInfo file = new FileInfo(e.FullPath);
            Console.WriteLine($"{e.Name} is created!");
        }

        private static void FileChanged(object sender, FileSystemEventArgs e)
        {
            //FileInfo file = new FileInfo(e.FullPath);
            Console.WriteLine($"{e.Name} is changed!");
        }

        private static void FileDeleted(object sender, FileSystemEventArgs e)
        {
            //FileInfo file = new FileInfo(e.FullPath);
            Console.WriteLine($"{e.Name} is deleted!");
        }
    }
}
