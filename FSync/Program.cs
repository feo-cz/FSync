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
        static bool r           = false;
        static bool f           = false;
        static string z         = "";
        static string e         = @"^.+\.*$";
        static string i         = "";
        static string SRCDIR    = "";
        static string DESTDIR   = "";

        static void Main(string[] args)
        {

            setParams(args);

            FSync_lib.FSync_lib.setR(r);
            FSync_lib.FSync_lib.setF(f);
            FSync_lib.FSync_lib.setZ(z);
            FSync_lib.FSync_lib.setE(e);
            FSync_lib.FSync_lib.setR(i);
            FSync_lib.FSync_lib.setSRCDIR(SRCDIR);
            FSync_lib.FSync_lib.setDESTDIR(DESTDIR);

            FSync_lib.FSync_lib.run();

            return;
        }

        private static void setParams(string[] args)
        {
            // Testovací hodnoty
            /*SRCDIR  = @"C:\directory\";
            DESTDIR = @"C:\directoryDEST\";
            i       = "index.txt";
            r       = true;
            f       = true;
            z       = "";*/

            for (int j = 0; j < args.Length; j++)
            {
                switch (args[j])
                {
                    case "-r":
                        r = true;
                        break;
                    case "-f":
                        f = true;
                        break;
                    case "-z":
                        DateTime date = DateTime.Now;
                        string dateString = date.ToString("yyyyMMddHHmmss");

                        z = dateString + args[j + 1] + ".zip";
                        break;
                    case "-e":
                        e = @"^.+\.(" + args[j + 1].Replace(",", "|") + ")$";
                        break;
                    case "-i":
                        i = args[j + 1];
                        break;
                    case "-SRCDIR":
                        SRCDIR = args[j + 1];
                        break;
                    case "-DESTDIR":
                        DESTDIR = args[j + 1];
                        break;
                }
            }
        }
    }
}
