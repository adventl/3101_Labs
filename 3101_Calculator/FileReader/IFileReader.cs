using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public interface IFileReader
    {
        string[] Read(string path);
    }
}