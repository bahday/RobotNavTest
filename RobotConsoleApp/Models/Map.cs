using RobotConsoleApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotConsoleApp.Models
{
    public class Map
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Map(string sizeString)
        {
            int sizeSeparationSymbolIndx = sizeString.IndexOf(Constants.SizeSeparator);

            X = Constants.mapX;
            Y = Constants.mapY;
            Width = int.Parse(sizeString.Substring(0, sizeSeparationSymbolIndx));
            Height = int.Parse(sizeString.Substring(sizeSeparationSymbolIndx + 1));

        }

    }
}
