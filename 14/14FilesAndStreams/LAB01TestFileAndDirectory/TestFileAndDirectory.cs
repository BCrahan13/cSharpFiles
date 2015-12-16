using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LAB01TestFileAndDirectory
{
    class TestFileAndDirectory
    {
        static void Main(string[] args)
        {
            string directoryName = "";
            string sentinalVal = "end";
            string[] listOfFiles;

            while (directoryName != sentinalVal)
            {
                //Ask for dir
                Write("Enter a directory name: ");
                directoryName = ReadLine();
                if (Directory.Exists(directoryName)) //if the directory: (directoryName) exists ...
                {
                    WriteLine("Directory exists, " + "and it contains the following: ");
                    listOfFiles = Directory.GetFiles(directoryName);
                    for (int tempVar = 0; tempVar < listOfFiles.Length; ++tempVar)
                        WriteLine("\t{0}", listOfFiles[tempVar]);
                }   //if(Directory.Exists(directoryName))
                else
                {
                    Write("Directory does not exist");
                }   //else

                //Ask for file
                Write("Enter file name: ");
                directoryName = ReadLine();
                if (File.Exists(directoryName)) //if the file: (directoryName) exists ...
                {
                    WriteLine("File was created " + "\t" + File.GetCreationTime(directoryName));
                }   //if(File.Exists(directoryName))
                else
                {
                    WriteLine("File does not exist");
                }   //else
            }   //while
        }
    }
}
