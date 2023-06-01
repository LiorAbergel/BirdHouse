namespace DemoLibrary
{
    public class Cage
    {
        // Enums
        public enum Materials { Steel, Wood, Plastic }

        // Class Fields
        public string Serial { get; set; }
        public string Length { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string Material { get; set; }
        public string OwnerID { get; set; }

        public Cage(string ownerID, string serial, string length, string width, string height, string material)
        {
            OwnerID = ownerID;
            Serial = serial;
            Length = length;
            Width = width;
            Height = height;
            Material = material;
        }


    }
}
