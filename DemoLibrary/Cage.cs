using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Cage
    {
        public enum Material { Steel, Wood, Plastic }

        private List<Bird> birds;

        public Cage(string ownerID, string serial, string length, string width, string height, string material)
        {
            this.ownerID = ownerID;
            this.serial = serial;
            this.length = length;
            this.width = width;
            this.height = height;
            this.material = material;
            birds = new List<Bird>();
        }

        public string serial { get; set; }
        public string length { get; set; }
        public string width { get; set; }  
        public string height { get; set; }
        public string material { get; set; }
        public string ownerID { get; set; }
    }
}
