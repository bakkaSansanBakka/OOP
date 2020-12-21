using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace lab13
{
    public static class PPPDiskInfo
    {
        public static void DisplayTotalFreeSpace(string driveName)
        {
            DriveInfo drive = new DriveInfo(driveName);
            MethodBase currentMethod = MethodBase.GetCurrentMethod();
            PPPLog.ToFile($"Метод – {currentMethod}, время – {DateTime.Now}, всего свободного места на диске {driveName} – {drive.TotalFreeSpace}");
        }
        public static void DisplayDriveFormat(string driveName)
        {
            DriveInfo drive = new DriveInfo(driveName);
            MethodBase currentMethod = MethodBase.GetCurrentMethod();
            PPPLog.ToFile($"Метод – {currentMethod}, время – {DateTime.Now}, имя файловой системы – {drive.DriveFormat}");
        }
        public static void DisplayDiskInfo()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            string log = $"Метод – {MethodBase.GetCurrentMethod()}, время – {DateTime.Now}:\n";
            foreach(var drive in drives)
            {
                log += $"имя диска – {drive.Name}, объем – {drive.TotalSize}, доступный объем – {drive.AvailableFreeSpace}, метка тома – {drive.VolumeLabel}\n";
            }
            PPPLog.ToFile(log);
        }
    }
}
