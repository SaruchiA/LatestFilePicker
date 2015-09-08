using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LatestFilePicker
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir = @"D:\REPOSITORY\Phoenix\services\JackSparrow\bin\Debug\api-responses";
            string[] allFiles = Directory.GetFiles(dir);
            String latestFileName=string.Empty;
           
            for (int i = 0; i < allFiles.Length; i++)
            {
                if (allFiles[i].Contains("_GEOTREE-RS_"))
                {
                    DateTime createdTime_File1 = File.GetLastWriteTimeUtc(allFiles[i]);
                    latestFileName=allFiles[i];
                    DateTime createdTime_NewFile= new DateTime();
                    if (createdTime_File1 > createdTime_NewFile)
                    {
                        createdTime_NewFile = createdTime_File1;
                        latestFileName = allFiles[i];
                    }

                }
            }
        }
    }
}
