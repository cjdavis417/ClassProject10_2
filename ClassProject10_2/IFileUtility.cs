﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject10_2
{
    public interface IFileUtility
    {
        // Add a interface method called WriteToFile here:
        // It should return void and take a string parameter called value
        void WriteToFile(string value);
        // Add another interface method called ReadFromFile
        // It should return a string and take no parameters
        string ReadFromFile();

    }
}
