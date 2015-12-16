using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace YDI01ReadNameFile
{
    class ReadNameFile
    {
        static void Main(string[] args)
        {
            //../../../YDI01CreateNameFile/bin/Debug/Names.txt
            FileStream file = new FileStream("Names.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            int count = 1;
            //string name;

            WriteLine("Displaying all names");
            string name = reader.ReadLine();
            while(name != null)
            {
                WriteLine("" + count + " " + name);
                name = reader.ReadLine();
                ++count;
            }

            reader.Close();
            file.Close();
        }
    }
}
