using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksCsharp
{
    internal class Filesconcept
    {
        public static int Mul_write(params int[] number)
        {
            FileInfo fileinfo = new FileInfo(@"C:\Users\ei13081\Documents\filesconcept\Multi_table.txt");
            FileStream fs=fileinfo.Open(FileMode.OpenOrCreate,FileAccess.ReadWrite,FileShare.ReadWrite);
            StreamWriter writer=new StreamWriter(fs);
            writer.WriteLine("MULTIPLICATION TABLE:");

            try
            {
                foreach (int i in number)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        writer.WriteLine("{0} * {1}= {2}", i, j, (i * j));
                    }
                    writer.WriteLine("-----------------------------------------------------");
                }

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                writer.Close();
                fs.Close();

            }

            return 0;


        }
        public static void Mul_read(params int[] number)
        {
            FileInfo fileInfo = new FileInfo(@"C:\Users\ei13081\Documents\filesconcept\Multi_table.txt");
            FileStream fs = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader reader=new StreamReader(fs);
           
            try
            {
               string contents=reader.ReadToEnd();
                Console.WriteLine(contents);
             

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                reader.Close();
                fs.Close();
            }
        }
        public static void File_Copy()
        {
            string path = @"C:\Users\ei13081\Documents\filesconcept\mainfile.txt";
            FileInfo fileinfo = new FileInfo(path);
            FileStream fs = fileinfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamWriter writer = new StreamWriter(fs);
            try
            {
                writer.WriteLine("copied contents");
                string des= @"C:\Users\ei13081\Documents\filesconcept\Copied_file.txt";
                File.Copy(path, des,true);
              
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                writer.Close();
                fs.Close();
            }
        }
        public static void Main()
        {
            Mul_write(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Mul_read();
            File_Copy();
            //File.Move(@"C:\Users\ei13081\Documents\filesconcept\MOVED_file.txt", @"C:\Users\ei13081\Documents\filesconcept\move_op.txt");
            File.Delete(@"C:\Users\ei13081\Documents\filesconcept\deleting file.txt");
          
            Console.WriteLine("First line from the file is:");
            string[] contents;
            contents = File.ReadAllLines(@"C:\Users\ei13081\Documents\filesconcept\Multi_table.txt");
            Console.WriteLine(contents[0]);
            StreamReader sr = File.OpenText(@"C:\Users\ei13081\Documents\filesconcept\Multi_table.txt");
            string[] contents1=null;
            int Count = 0;
            while (sr.ReadLine() != null)
            {
                Count ++;
            }
            Console.WriteLine("Total count of lines:"+Count);

        }
    }
}
