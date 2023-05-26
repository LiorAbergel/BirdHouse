using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Cage
    {
        public enum Materials { Steel, Wood, Plastic }

        public Cage(string ownerID, string serial, string length, string width, string height, string material)
        {
            this.OwnerID = ownerID;
            this.Serial = serial;
            this.Length = length;
            this.Width = width;
            this.Height = height;
            this.Material = material;
        }

        public string Serial { get; set; }
        public string Length { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string Material { get; set; }
        public string OwnerID { get; set; }
    }
}
