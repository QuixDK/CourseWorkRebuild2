using SharpCompress.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CourseWorkRebuild2
{
    internal class Save
    {
        public void SaveElevatorTable(DataTable dataTable, DataGridView dataGridView, SQLiteConnection connection, String pathToTable)
        {

        }

        public void SaveTxtFile(String pathToFile, Double tValue, int buildingsCount, int marksCount)
        {
            List<String> valueLines = File.ReadAllLines(pathToFile, Encoding.Unicode).ToList();
            StreamReader reader = new StreamReader(pathToFile, Encoding.Unicode);
            String content = reader.ReadToEnd();
            reader.Close();
            

            foreach (String line in valueLines)
            {
                if (line.StartsWith("Точность измерений"))
                {
                    line.ToString();

                    String newLine = "Точность измерений: " + tValue + "м";

                    content = Regex.Replace(content, line, newLine);
                    
                    
                }
                if (line.StartsWith("Количество структурных блоков"))
                {
                    line.ToString();
                    String newLine = "Количество структурных блоков: " + buildingsCount;

                    content = Regex.Replace(content, line, newLine);
                    
                }
                if (line.StartsWith("Количество геодезических марок, закрепленных в теле объекта"))
                {
                    String newLine = "Количество геодезических марок, закрепленных в теле объекта: " + marksCount;
                    content = Regex.Replace(content, line, newLine);
                    
                }
            }
            File.WriteAllText(pathToFile, content, Encoding.Unicode);
            
        }

    }
}
