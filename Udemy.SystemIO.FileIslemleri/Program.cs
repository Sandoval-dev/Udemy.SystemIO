using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Udemy.SystemIO.FileIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            bool fileKontrol = File.Exists("C:\\Udemy\\merhaba.txt");
            if (fileKontrol)
            {
                Console.WriteLine("Dosya var.");
            }
            else
            {
                FileCreate("C:\\Udemy\\merhaba.txt");
            }
            //FileCreate("C:\\Udemy\\merhaba.txt");
           string metindegeri= File.ReadAllText("C:\\Udemy\\merhaba.txt");
            Console.WriteLine(metindegeri);
            
            File.AppendAllText("C:\\Udemy\\merhaba.txt", "Merhaba TXT");
            

            File.Move("C:\\Udemy\\merhaba.txt","C:\\Udemy2\\merhaba.txt");


            File.Copy("C:\\Udemy2\\merhaba.txt", "C:\\Udemy\\merhaba.txt");

            //File.Delete("C:\\Udemy\\merhaba.txt");
        }

        static void FileCreate(string path)
        {
          FileStream fileStream=  File.Create(path);
            fileStream.Close(); //eğer kapatmazsam onu tam olarak algılayamaz. İçine bir şey yazınca başka bir yere kaydetmeni ister.
        }

        static bool FileExists(string path)
        {
          return  File.Exists(path); //Dosyanın olup olmadığının kontrolünü sağlar.
        
        }

        static void FileDelete(string path)
        {
            File.Delete(path);
        }
      

        static void FileMove(string kaynak,string hedef) 
        {
            File.Move(kaynak, hedef);

        }

        static void FileCopy(string kaynak,string hedef)
        {
            File.Copy(kaynak, hedef);
        }

        static void FileAppendText(string path,string text)
        {
            File.AppendAllText(path,text); //txt nin içine yazı yazdırmak için bu metotu kullanırız.
            
        }

        static string FileReadAllText(string path)
        {
          string metin=  File.ReadAllText(path);
            return metin;
        }

    }
}
