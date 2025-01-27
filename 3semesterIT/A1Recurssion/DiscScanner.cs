using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.A1Recurssion
{
    public class DiscScanner
    {
        public static void ScanDir(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] files = dir.GetFiles();

            // Udskriver alle filerne
            foreach (FileInfo file in files)
            {
                Console.WriteLine(file.Name);
            }
            DirectoryInfo[] dirs = dir.GetDirectories();

            // Kalder rekursivt på alle undermapper
            foreach (DirectoryInfo subdir in dirs)
            {
                ScanDir(subdir.FullName);
            }
        }

        public static int numberOfFiles(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            int result = 0;
            try
            {
                DirectoryInfo[] dirs = dir.GetDirectories();
                result = dirs.Length;
                foreach (DirectoryInfo subdir in dirs)
                {
                    result += numberOfFiles(subdir.FullName);
                }
            }
            catch
            {
            }
            return result;
        }

        public static void prettyfyPrint(string path, string prepend)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                FileInfo[] files = dir.GetFiles();

                foreach (FileInfo file in files)
                {
                    Console.WriteLine(prepend + file.Name);
                }
                DirectoryInfo[] dirs = dir.GetDirectories();
                foreach (DirectoryInfo subdir in dirs)
                {
                    Console.WriteLine(prepend + subdir.Name);
                    prettyfyPrint(subdir.FullName, prepend + "  ");
                }
            }
            catch { }
        }
    }
}
