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

    internal class Bird
    {
        private string serial;
        private string specie;
        private string subsSpecies;
        private DateTime hatchDate;
        private string gender;
        private string cageSerial;
        private string fatherSerial;
        private string motherSerial;

        //public Bird(string serial, Species specie, SubSpecies subSpecies, DateTime hatchDate, string gender, string cageNum, string fatherSerial, string motherSerial)
        //{
        //    this.serial = serial;
        //    this.specie = specie;
        //    this.subsSpecies = subSpecies;
        //    this.hatchDate = hatchDate;
        //    this.gender = gender;
        //    this.cageNum = cageNum;
        //    this.fatherSerial = fatherSerial;
        //    this.motherSerial = motherSerial;
        //}
        public Bird(string serial, string specie, string subsSpecies, DateTime hatchDate, string gender, string cageNum, string fatherSerial, string motherSerial)
        {
            this.serial = serial;
            this.specie = specie;
            this.subsSpecies = subSpecies;
            this.hatchDate = hatchDate;
            this.gender = gender;
            this.cageSerial = cageNum;
            this.fatherSerial = fatherSerial;
            this.motherSerial = motherSerial;
        }

        public string Serial
        {
            get { return serial; }
            set { serial = value; }
        }

        public string Specie
        {
            get { return specie; }
            set { specie = value; }
        }

        public string subSpecies
        {
            get { return subSpecies; }
            set { subSpecies = value; }
        }

        public DateTime HatchDate
        {
            get { return hatchDate; }
            set { hatchDate = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string CageNum
        {
            get { return cageSerial; }
            set { cageSerial = value; }
        }

        public string FatherSerial
        {
            get { return fatherSerial; }
            set { fatherSerial = value; }
        }

        public string MotherSerial
        {
            get { return motherSerial; }
            set { motherSerial = value; }
        }

    }
}
