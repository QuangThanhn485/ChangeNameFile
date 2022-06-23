using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeNameIMG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folder = @"E:\work\anh cong trinh 4\";
            DirectoryInfo d = new DirectoryInfo(folder); //Assuming Test is your Folder

            FileInfo[] Files = d.GetFiles();//GetFiles(".exe"); //Getting Text files
            string str = "";
            int count = 0;
            foreach (FileInfo filee in Files)
            {
                str = str + ", " + filee.Name;
                //System.IO.File.Move(folder+filee.Name, folder+filee.Name+ ".jpg");
                count++;
            }
            Console.WriteLine("count : "+count);
            Console.WriteLine("xong");
            Console.Read();
        }
    }
}
