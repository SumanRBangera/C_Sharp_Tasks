using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tasks
{
    public class FilesMultiplicationTable
    {
        public void Write()
        {
            //Specify the filename and the path of the file to be created 
            //Fileinfo - class
            FileInfo fileInfo = new FileInfo(@"C:\Users\EI13098\Desktop\blogs\DotNet\Task 17\Multiplication.txt");
            FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamWriter writer = new StreamWriter(fileStream);
            try
            {
                int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                int a = 1, res;
                for (int i = 1; i <= 10; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        res = a * j;
                        writer.WriteLine($"{a} x {j}  = {res}");

                    }
                    writer.WriteLine("--------------------------------------------");
                    a++;
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                writer.Close();
                fileStream.Close();
            }

        }
        public void read()
        {

            //Specify the filename and the path of the file to be created 
            //Fileinfo - class
            FileInfo fileInfo = new FileInfo(@"C:\Users\EI13098\Desktop\blogs\DotNet\Task 17\Source\Move.txt");
            FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader reader = new StreamReader(fileStream);
            try
            {
                string contents = reader.ReadToEnd();
             
                Console.WriteLine(contents);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                reader.Close();
                fileStream.Close();
            }

        }
    }
    internal class FileMultiplication
    {
        public static void Main()
        {
            FilesMultiplicationTable table = new FilesMultiplicationTable();
            table.Write();
            table.read();
        }
    }
}
