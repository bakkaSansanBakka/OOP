using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace lab13
{
    public static class PPPFileInfo
    {
        public static void GetFullPath(string filePath)
        {
            FileInfo file = new FileInfo(filePath);
            PPPLog.ToFile($"Метод – {MethodBase.GetCurrentMethod()}, время – {DateTime.Now}, полный путь к файлу {file.Name} – {file.FullName}");
        }
        public static void GetFileInfo(string filePath)
        {
            FileInfo file = new FileInfo(filePath);
            PPPLog.ToFile($"Метод – {MethodBase.GetCurrentMethod()}, время – {DateTime.Now}, размер файла {file.Name} – {file.Length}, расширение – {file.Extension}");
        }
        public static void GetCreationAndChangeInfo(string filePath)
        {
            FileInfo file = new FileInfo(filePath);
            PPPLog.ToFile($"Метод – {MethodBase.GetCurrentMethod()}, время – {DateTime.Now}, дата создания файла {file.Name} – {file.CreationTime}, " +
                $"дата изменения – {File.GetLastWriteTime(filePath)}");
        }
    }
}
