using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace lab13
{
    static class PPPDirInfo
    {
        public static void FilesAmount(string directory)
        {
            string[] files = Directory.GetFiles(directory);
            PPPLog.ToFile($"Метод – {MethodBase.GetCurrentMethod()}, время – {DateTime.Now}, количество файлов в директории {directory} – {files.Length}");
        }
        public static void GetCreationTime(string directory)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(directory);
            PPPLog.ToFile($"Метод – {MethodBase.GetCurrentMethod()}, время – {DateTime.Now}, время создания каталога {directory} – {dirInfo.CreationTime}");
        }
        public static void SubdirectoriesAmount(string directory)
        {
            string[] subDirecories = Directory.GetDirectories(directory);
            PPPLog.ToFile($"Метод – {MethodBase.GetCurrentMethod()}, время – {DateTime.Now}, количество подкаталогов каталога {directory} " +
                $"– {subDirecories.Length}");
        }
        public static void DisplayParentDirectories(string directory)
        {
            PPPLog.ToFile($"Метод – {MethodBase.GetCurrentMethod()}, время – {DateTime.Now}, " +
                $"родительские директории каталога {directory} – {Directory.GetParent(directory)}");
        }
    }
}
