﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IW4MAdmin.Discord.Debugging
{
    class ConfigException : Exception
    {
        public ConfigException(string msg) : base(msg) { }
    }
}
