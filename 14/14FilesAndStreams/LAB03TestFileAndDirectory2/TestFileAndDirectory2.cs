using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Console;

namespace LAB03TestFileAndDirectory2
{
    static class TestFileAndDirectory2
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TestFileAndDirectory2Form());

            FileStream file = new FileStream("Names.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);
            string[] names = {  "Anthony    ",
                                "Belle      ",
                                "Carolyn    ",
                                "David      ",
                                "Edwin      ",
                                "Frannie    ",
                                "Gina       ",
                                "Hannah     ",
                                "Inez       ",
                                "Juan       "   };

            for (int x = 0; x < names.Length; ++x)
                writer.WriteLine(names[x]);

            writer.Close();
            file.Close();
        }
    }
}
