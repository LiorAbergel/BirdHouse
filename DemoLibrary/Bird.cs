using System;

namespace DemoLibrary
{
    public class Bird
    {
        // Enums
        public enum SubSpeciesAM { North, Center, South }
        public enum SubSpeciesEU { West, East }
        public enum SubSpeciesAU { Center, Beach }
        public enum Species { American, European, Australian }

        // Class Fields
        public string Serial { get; set; }
        public string Specie { get; set; }
        public string SubSpecie { get; set; }
        public DateTime HatchDate { get; set; }
        public string Gender { get; set; }
        public string CageSerial { get; set; }
        public string FatherSerial { get; set; }
        public string MotherSerial { get; set; }

        // Parameterless default constructor
        public Bird() { }

        public Bird(string serial, string specie, string subSpecie, DateTime hatchDate, string gender, string cageSerial , string fatherSerial, string motherSerial) 
        {
            Serial = serial;
            Specie = specie;
            SubSpecie = subSpecie;
            HatchDate = hatchDate;
            Gender = gender;
            CageSerial = cageSerial;
            FatherSerial = fatherSerial;
            MotherSerial = motherSerial;
        }


    }
}
