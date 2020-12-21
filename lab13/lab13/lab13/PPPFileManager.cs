using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.IO.Compression;
//using System.IO.Compression.FileSystem;

namespace lab13
{
    static class PPPFileManager
    {
        public static string GetFilesAndDirectories(string drive)
        {
            string[] dirs = Directory.GetDirectories(drive);
            string[] files = Directory.GetFiles(drive);
            string str = "Папки:\n";
            foreach (string dir in dirs)
            {
                str += $"{dir}\n";
            }
            str += "Файлы:\n";
            foreach (string file in files)
            {
                str += $"{file}\n";
            }
            PPPLog.ToFile($"Метод – {MethodBase.GetCurrentMethod()}, время – {DateTime.Now}, действие – получение списка файлов и каталогов диска {drive}");
            return str;
        }
        public static void CreateDirectory(string path)
        {
            try
            {
                Directory.CreateDirectory(path);
                PPPLog.ToFile($"Метод – {MethodBase.GetCurrentMethod()}, время – {DateTime.Now}, действие – создание нового каталога по пути {path}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void CreateFile(string path)
        {
            try
            {
                var file = File.Create(path);
                file.Close();
                PPPLog.ToFile($"Метод – {MethodBase.GetCurrentMethod()}, время – {DateTime.Now}, действие – создание нового файла по пути {path}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void ToFile(string path, string info)
        {
            //File.WriteAllText(path, info);
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(info);
            }
            PPPLog.ToFile($"Метод – {MethodBase.GetCurrentMethod()}, время – {DateTime.Now}, действие – запись в файл по пути {path}");
        }
        public static void CopyFile(string sourceFile, string destFile)
        {
            try
            {
                File.Copy(sourceFile, destFile);
                PPPLog.ToFile($"Метод – {MethodBase.GetCurrentMethod()}, время – {DateTime.Now}, действие – копирование файла по пути {sourceFile} в {destFile}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void RenameFile(string path, string newName)
        {
            try
            {
                FileInfo file = new FileInfo(path);
                file.MoveTo(file.Directory.FullName + "\\" + newName);
                PPPLog.ToFile($"Метод – {MethodBase.GetCurrentMethod()}, время – {DateTime.Now}, действие – переименование файла по пути {path} в {newName}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void DeleteFile(string path)
        {
            try
            {
                File.Delete(path);
                PPPLog.ToFile($"Метод – {MethodBase.GetCurrentMethod()}, время – {DateTime.Now}, действие – удаление файла по пути {path}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void CopyFiles(string sourcePath, string destPath, string fileType)
        {
            try
            {
                var source = new DirectoryInfo(sourcePath);
                var dest = new DirectoryInfo(destPath);
                foreach (var file in source.GetFiles(fileType))
                {
                    file.CopyTo(dest + file.Name, true);
                }
                Directory.Delete(destPath);

                PPPLog.ToFile($"Метод – {MethodBase.GetCurrentMethod()}, время – {DateTime.Now}, действие – копирование файлов с расширением {fileType}" +
                    $" из {sourcePath} в {destPath}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void MoveDirectory(string sourcePath, string destPath)
        {
            try
            {
                Directory.Move(sourcePath, destPath);
                PPPLog.ToFile($"Метод – {MethodBase.GetCurrentMethod()}, время – {DateTime.Now}, действие – перемещение каталога {sourcePath} в {destPath}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void ToZip(string path, string zipName) 
        {
            try
            {
                ZipFile.CreateFromDirectory(path, zipName);
                PPPLog.ToFile($"Метод – {MethodBase.GetCurrentMethod()}, время – {DateTime.Now}, действие – архивирование каталога {path} в {zipName}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void UnZip(string zipName, string path)
        {
            try
            {
                ZipFile.ExtractToDirectory(zipName, path);
                PPPLog.ToFile($"Метод – {MethodBase.GetCurrentMethod()}, время – {DateTime.Now}, действие – разархивирование файла {zipName} в {path}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
