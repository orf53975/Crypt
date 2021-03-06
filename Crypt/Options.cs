﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypt
{
    public struct Options
    {
        public string buildDir;
        public string hostDir;

        public EncryptionType encryptionType;
        public Byte[] encryptionKey;

        public string resFileName;
        public string resPayloadName;
        public string resLoaderName;
    }

    public enum EncryptionType
    {
        Rijndael,
        XOR
    }
}
