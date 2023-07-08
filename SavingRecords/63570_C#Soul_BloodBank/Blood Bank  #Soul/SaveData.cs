using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank___Soul
{
    internal static class SaveData
    {
 
        //truly genius method which reads all the data from the txt file and transforms it to two dimensional List
        public static void db_filling()
        {
            using (FileStream sw = new FileStream(Data.file, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(sw))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Data.local_db.Add(line.Split(';').ToList());
                    }
                }
            }
        }

        //this one creates the string that will be saved to the path, the best database ever
        public static void CreateList(List<string> list)
        {
            using (FileStream sw = new FileStream(Data.file, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw2 = new StreamWriter(sw))
                {
                    string line = "";
                    foreach (string s in list)
                    {
                        line += s + ";";
                    }
                    sw2.WriteLine(line);
                }
            }
        }


    }
}



 
    