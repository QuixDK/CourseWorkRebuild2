using SharpCompress.Archives;
using SharpCompress.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CourseWorkRebuild2
{
    internal class OpenProject
    {
        private String projectRoot = "";
        public List<String> Open()
        {
            String valueOfT = "";
            String buildingCount = "";
            String markCount = "";
            String defaultValueA = "0,9";
            List<String> result = new List<String>();

            if (projectRoot == "")
            {
                FolderBrowserDialog selectProjectPath = new FolderBrowserDialog();
                selectProjectPath.SelectedPath = "D:\\Projects";
                selectProjectPath.Description = "Выберите проект";

                if (selectProjectPath.ShowDialog() == DialogResult.OK)
                {
                    projectRoot = selectProjectPath.SelectedPath;
                }
            }
            String dbFilePath = "";
            String pngFilePath = "";
            String txtFilePath = "";
            String fileName = "";
            if (projectRoot.Equals(""))
            {
                // throw new NullProjectRootException("Не указана папка с проектом");
            }
            else
            {
                fileName = Path.GetFullPath(projectRoot);
                OpenFileDialog chooseFile = new OpenFileDialog();
                chooseFile.InitialDirectory = projectRoot;
                chooseFile.Multiselect = false;

                int dbFilesCount = Directory.GetFiles(projectRoot, "*.sqlite").Length;
                int pngFilesCount = Directory.GetFiles(projectRoot, "*.png").Length;
                int txtFilesCount = Directory.GetFiles(projectRoot, "*.txt").Length;

                if (dbFilesCount > 1 | dbFilesCount == 0)
                {
                    chooseFile.Title = "Выберите таблицу высот";
                    chooseFile.Filter = "SQLite files (*.sqlite)|*.sqlite";
                    dbFilePath = ChoosePathToFile(projectRoot, chooseFile);
                }
                else dbFilePath = Path.GetFullPath(Directory.GetFiles(projectRoot, "*.sqlite")[0]);

                if (pngFilesCount > 1 | pngFilesCount == 0)
                {
                    chooseFile.Title = "Выберите схему объекта";
                    chooseFile.Filter = "PNG files (*.png)|*.png";
                    pngFilePath = ChoosePathToFile(projectRoot, chooseFile);
                }
                else pngFilePath = Path.GetFullPath(Directory.GetFiles(projectRoot, "*.png")[0]);

                if (txtFilesCount > 1 | txtFilesCount == 0)
                {
                    chooseFile.Title = "Выберите текстовый документ с данными";
                    chooseFile.Filter = "Text files (*.txt)|*.txt";
                    txtFilePath = ChoosePathToFile(projectRoot, chooseFile);
                }
                else txtFilePath = Path.GetFullPath(Directory.GetFiles(projectRoot, "*.txt")[0]);

                if (!txtFilePath.Equals(""))
                {
                    List<String> valueLines = File.ReadAllLines(txtFilePath, Encoding.Unicode).ToList();

                    foreach (String valueLine in valueLines)
                    {
                        if (valueLine.StartsWith("Точность измерений"))
                        {
                            List<String> line = valueLine.Split(' ').ToList();
                            valueOfT = line[2].Split('м')[0];

                        }
                        if (valueLine.StartsWith("Количество структурных блоков"))
                        {
                            List<String> line = valueLine.Split(' ').ToList();
                            buildingCount = line[3];

                        }
                        if (valueLine.StartsWith("Количество геодезических марок, закрепленных в теле объекта"))
                        {
                            List<String> line = valueLine.Split(' ').ToList();
                            markCount = line[7];

                        }
                    }
                }
               
            }
            result.Add(dbFilePath); //0
            result.Add(pngFilePath); //1
            result.Add(valueOfT); //2
            if (dbFilePath == "" & pngFilePath == "" & txtFilePath == "")
            {
                defaultValueA = "";
            }
            result.Add(defaultValueA); //3
            result.Add(markCount); //4
            result.Add(buildingCount); //5
            result.Add(fileName); //6
            result.Add(txtFilePath); //7
            projectRoot = "";
            return result;
        }

        public List<String> UnzipRar()
        {
            try
            {
                projectRoot = "";
                String archivePath = "";
                OpenFileDialog chooseRarFile = new OpenFileDialog();
                chooseRarFile.Title = "Выберите архив с проектом";
                chooseRarFile.Filter = "RAR files(*.rar) | *.rar";
                chooseRarFile.Multiselect = false;

                if (chooseRarFile.ShowDialog() == DialogResult.OK)
                {
                    archivePath = Path.GetFullPath(chooseRarFile.FileName);
                }

                FolderBrowserDialog chooseDirectory = new FolderBrowserDialog();
                chooseDirectory.Description = "Выберите папку для сохранения проекта";
                String filePath = "";
                if (chooseDirectory.ShowDialog() == DialogResult.OK)
                {
                    filePath = Path.GetFullPath(chooseDirectory.SelectedPath);
                }
                

                if (archivePath != "")
                {
                    using (var archive = ArchiveFactory.Open(archivePath))
                    {

                        foreach (var entry in archive.Entries)
                        {

                            string outputPath = Path.Combine(filePath, entry.Key);

                            Directory.CreateDirectory(Path.GetDirectoryName(outputPath));

                            entry.WriteToDirectory(filePath, new ExtractionOptions
                            {
                                ExtractFullPath = true,
                                Overwrite = true
                            });

                            if (archive.Entries.Count() == 4)
                            {
                                projectRoot = Path.GetFullPath(Path.GetDirectoryName(outputPath));
                                break;
                            }
                        }
                    }
                }
                return Open();
            }
            catch (System.IO.IOException ex)
            {
                MessageBox.Show("Файл уже открыт в другом окне, выберите другой файл");
                projectRoot = "";
                return Open();
            }
        }
        private String ChoosePathToFile(String projectRoot, OpenFileDialog chooseFile)
        {
            String filePath = "";
            if (chooseFile.ShowDialog() == DialogResult.OK)
            {
                filePath = Path.GetFullPath(chooseFile.FileName);
            }
            return filePath;
        }

        public List<String> ReadValuesFromTxtFile(String txtFilePath)
        {
            List<String> values = new List<String>();
            List<String> valueLines = File.ReadAllLines(txtFilePath, Encoding.Unicode).ToList();
            if (!txtFilePath.Equals(""))
            {
                foreach (String valueLine in valueLines)
                {
                    if (valueLine.StartsWith("Точность измерений"))
                    {
                        List<String> line = valueLine.Split(' ').ToList();
                        values.Add(line[2].Split('м')[0]);

                    }
                    if (valueLine.StartsWith("Количество структурных блоков"))
                    {
                        List<String> line = valueLine.Split(' ').ToList();
                        values.Add(line[3]);

                    }
                    if (valueLine.StartsWith("Количество геодезических марок, закрепленных в теле объекта"))
                    {
                        List<String> line = valueLine.Split(' ').ToList();
                        values.Add(line[7]);

                    }
                }
            }
            
            return values;
        }
    }

}
