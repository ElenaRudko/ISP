using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.IO;

namespace ClassLibrary1
{
    public class BasicInfo
    {

        public void print()
        {

            foreach (var drive in DriveInfo.GetDrives())
            {
                try
                {
                    Console.WriteLine("Имя диска: " + drive.Name);
                    Console.WriteLine("Файловая система: " + drive.DriveFormat);
                    Console.WriteLine("Тип диска: " + drive.DriveType);
                    Console.WriteLine("Объем доступного своболного места (в байтах): " + drive.AvailableFreeSpace);
                    Console.WriteLine("Готов ли диск: " + drive.IsReady);
                    Console.WriteLine("Корневой каталог диска: " + drive.RootDirectory);
                    Console.WriteLine("Размер диска (в байтах): " + drive.TotalSize);
                    Console.WriteLine("Метка тома диска: " + drive.VolumeLabel);
                }
                catch { }
            }
        }
    }
}
