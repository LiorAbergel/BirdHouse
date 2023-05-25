using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public enum SubSpeciesAM { North, Center, South }
    public enum SubSpeciesEU { West, East }
    public enum SubSpeciesAU { Center, Beach }
    public enum Species { American, European, Australian }

    public class Bird
    {




        public Bird(string serial, string specie, string subSpecies, string hatchDate, string gender, string cageSerial, string fatherSerial, string motherSerial)
        {
            this.serial = serial;
            this.specie = specie;
            this.subSpecies = subSpecies;
            this.hatchDate = hatchDate;
            this.gender = gender;
            this.cageSerial = cageSerial;
            this.fatherSerial = fatherSerial;
            this.motherSerial = motherSerial;
        }

        public string serial
        {
            get;
            set;
        }

        public string specie
        {
            get;
            set;
        }

        public string subSpecies
        {
            get;
            set;
        }

        public string hatchDate
        {
            get;
            set;
        }

        public string gender
        {
            get;
            set;
        }

        public string cageSerial
        {
            get;
            set; 
        }

        public string fatherSerial
        {
        get;
        set;
        }

        public string motherSerial
        {
        get;
        set;
        }

    }
}
