using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class Car
    {
        public string Name { get; set; }
        public string Model { get; set; }
    }
    public class WhereBildCar
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }
}