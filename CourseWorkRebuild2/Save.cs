using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CourseWorkRebuild2
{
    internal class Save
    {
        public void SaveNewFile(String pathToNewFile, String oldPathToFile, String pattern)
        {
            String destinationFilePath = Path.Combine(Path.GetDirectoryName(oldPathToFile), Path.GetFileName(pathToNewFile));
            File.Copy(pathToNewFile, destinationFilePath, true);
            string[] oldFiles = Directory.GetFiles(Path.GetDirectoryName(oldPathToFile), pattern);
            for (int i = 0; i < oldFiles.Length; i++)
            {

                if (!Path.GetFileName(oldFiles[i]).Equals(Path.GetFileName(pathToNewFile)))
                {
                    File.Delete(oldFiles[i]);
                }

            }
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

        public void SaveFilesToNewFolder(string sourceFolderPath)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {

                string[] filesToCopy = Directory.GetFiles(sourceFolderPath);
                foreach (string fileToCopy in filesToCopy)
                {
                    string fileName = Path.GetFileName(fileToCopy);
                    string destinationFilePath = Path.Combine(folderBrowserDialog.SelectedPath, fileName);
                    File.Copy(fileToCopy, destinationFilePath);
                }

            }
        }



    }
}
