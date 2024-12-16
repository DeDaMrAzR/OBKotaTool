﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROTATool
{
    class Platform
    {
        public string name;
        public string extension;
    }
    internal class Platforms
    {
        public static Platform[] list = CreatePlatformsArray(); 
        internal static Platform[] CreatePlatformsArray()
        {
            return new Platform[]
            {
            new Platform { name = "OpenBK7231N", extension = ".rbl" },
            new Platform { name = "OpenBK7231T", extension = ".rbl" },
            //new Platform { name = "OpenBL602", extension = ".bin.xz" },
            new Platform { name = "OpenBL602", extension = ".bin.xz.ota" },
           // new Platform { name = "OpenESP32C2", extension = ".factory.bin" },
            new Platform { name = "OpenESP32C2", extension = ".img" },
           // new Platform { name = "OpenESP32C3", extension = ".factory.bin" },
            new Platform { name = "OpenESP32C3", extension = ".img" },
            //new Platform { name = "OpenESP32C6", extension = ".factory.bin" },
            new Platform { name = "OpenESP32C6", extension = ".img" },
            //new Platform { name = "OpenESP32S2", extension = ".factory.bin" },
            new Platform { name = "OpenESP32S2", extension = ".img" },
          //  new Platform { name = "OpenESP32S3", extension = ".factory.bin" },
            new Platform { name = "OpenESP32S3", extension = ".img" },
           // new Platform { name = "OpenESP32", extension = ".factory.bin" },
            new Platform { name = "OpenESP32", extension = ".img" },
            new Platform { name = "OpenLN882H", extension = "_OTA.bin" },
            new Platform { name = "OpenTR6260", extension = ".bin" },
            new Platform { name = "OpenW600", extension = ".img" },
            new Platform { name = "OpenW800", extension = ".img" }
            };
        }
    }
}
