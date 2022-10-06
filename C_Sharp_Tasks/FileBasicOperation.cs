using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tasks
{
    internal class FileBasicOperation
    {
        public static void Main()
        {
            
            string path = "C:\\Users\\EI13098\\Desktop\\blogs\\DotNet\\1\\1.txt";
            string path1 = "C:\\Users\\EI13098\\Desktop\\blogs\\DotNet\\1\\1.txt";
            string path2 = "C:\\Users\\EI13098\\Desktop\\blogs\\DotNet\\2\\2.txt";

            //file exists or not
            if (File.Exists(path))
            {
                //Copy file operation
                File.Copy(path, path2);


                //Move file operation
                File.Move(path2, path1);

                //Delete file operation
                File.Delete(path1);
            }
            else
            {
                Console.WriteLine("File does not Exist");
            }
        }
    }
}
