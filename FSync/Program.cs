using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSync_lib;

namespace FSync
{
    class Program
    {
        static bool allowCreateSubdirectories   = false;
        static bool allowOverwriteExistingFiles = false;
        static string ZIPfileSuffixName         = "";
        static int ZIPpartSizeMB                = 0;
        static string listOfAllowedExtensions   = @"^.+\.*$";
        static string indexFileName             = "";
        static string sourceDirectory           = "";
        static string destinationDirectory      = "";

        static void Main(string[] args)
        {

            Console.WriteLine("test");

            setParams(args);

            FSync_lib.FSync_lib.setAllowCreateSubdirectories(allowCreateSubdirectories);
            FSync_lib.FSync_lib.setAllowOverwriteExistingFiles(allowOverwriteExistingFiles);
            FSync_lib.FSync_lib.setZIPfileSuffixName(ZIPfileSuffixName);
            FSync_lib.FSync_lib.setZIPpartSizeMB(ZIPpartSizeMB);
            FSync_lib.FSync_lib.setListOfAllowedExtensions(listOfAllowedExtensions);
            FSync_lib.FSync_lib.setIndexFileName(indexFileName);
            FSync_lib.FSync_lib.setSourceDirectory(sourceDirectory);
            FSync_lib.FSync_lib.setDestinationDirectory(destinationDirectory);

            FSync_lib.FSync_lib.run();

            return;
        }

        private static void setParams(string[] args)
        {
            for (int j = 0; j < args.Length; j++)
            {
                switch (args[j])
                {
                    case "-r":
                        allowCreateSubdirectories = true;
                        break;
                    case "-f":
                        allowOverwriteExistingFiles = true;
                        break;
                    case "-z":
                        DateTime date = DateTime.Now;
                        string dateString = date.ToString("yyyyMMddHHmmss");

                        ZIPfileSuffixName = dateString + args[j + 1] + ".zip";
                        break;
                    case "-z_size":
                        ZIPpartSizeMB = Int32.Parse(args[j + 1]);
                        break;
                    case "-e":
                        listOfAllowedExtensions = @"^.+\.(" + args[j + 1].Replace(",", "|") + ")$";
                        break;
                    case "-i":
                        indexFileName = args[j + 1];
                        break;
                    case "-SRCDIR":
                        sourceDirectory = args[j + 1];
                        break;
                    case "-DESTDIR":
                        destinationDirectory = args[j + 1];
                        break;
                }
            }
        }
    }
}
