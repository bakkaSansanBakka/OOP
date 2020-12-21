using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Информация о дисках

            string disk = "C:";
            PPPDiskInfo.DisplayTotalFreeSpace(disk);
            PPPDiskInfo.DisplayDriveFormat(disk);
            PPPDiskInfo.DisplayDiskInfo();

            // Информация о файлах

            string filePath = @"E:\2 курс\OOP\lab13\lab13\lab13\PPPLogFile.txt";
            PPPFileInfo.GetFullPath(filePath);
            PPPFileInfo.GetFileInfo(filePath);
            PPPFileInfo.GetCreationAndChangeInfo(filePath);

            // Информация о директории

            string dirPath = @"E:\2 курс\OOP\";
            PPPDirInfo.FilesAmount(dirPath);
            PPPDirInfo.GetCreationTime(dirPath);
            PPPDirInfo.SubdirectoriesAmount(dirPath);
            PPPDirInfo.DisplayParentDirectories(dirPath);

            // Задание 5 - манипуляции с файлами и каталогами

            string drive = "F:";
            string dirpath = @"E:\2 курс\OOP\lab13\lab13\lab13\PPPInspect";
            string filepath = @"E:\2 курс\OOP\lab13\lab13\lab13\PPPInspect\pppdirinfo.txt";
            string filepath1 = @"E:\2 курс\OOP\lab13\lab13\lab13\PPPInspect\pppdirinfoSSSSS.txt";
            string filesAndDirectories = PPPFileManager.GetFilesAndDirectories(drive);

            PPPFileManager.CreateDirectory(dirpath);
            PPPFileManager.CreateFile(filepath);
            PPPFileManager.ToFile(filepath, filesAndDirectories);
            PPPFileManager.CopyFile(filepath, filepath1);
            PPPFileManager.RenameFile(filepath1, "pppdirinfoAAAAAAAAAAA.txt");
            PPPFileManager.DeleteFile(filepath);

            PPPFileManager.CreateDirectory(@"E:\2 курс\OOP\lab13\lab13\lab13\PPPFiles\t");
            PPPFileManager.CopyFiles(@"E:\pic", @"E:\2 курс\OOP\lab13\lab13\lab13\PPPFiles\t", "*.jpg");
            PPPFileManager.MoveDirectory(@"E:\2 курс\OOP\lab13\lab13\lab13\PPPFiles", @"E:\2 курс\OOP\lab13\lab13\lab13\PPPInspects");

            PPPFileManager.ToZip(@"E:\2 курс\OOP\lab13\lab13\lab13\PPPInspects", @"E:\2 курс\OOP\lab13\lab13\lab13\PPPInspects.zip");
            PPPFileManager.UnZip(@"E:\2 курс\OOP\lab13\lab13\lab13\PPPInspects.zip", @"E:\2 курс\OOP\lab13\lab13\lab13\PPPIn");

            Console.Read();
        }
    }
}
