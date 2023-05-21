namespace BirdHouse
{
    public enum Material { Steel, Wood, Plastic }

    internal class Cage
    {
        private string serial;
        private string length, width, height;
        private string material;
        private List<Bird> birds;

        public Cage(string serial, string length, string width, string height, string material)
        {
            this.serial = serial;
            this.length = length;   
            this.width = width;
            this.height = height;
            this.material = material;
            birds = new List<Bird>();

        }
        public string Serial
        {
            get { return serial; }
            set { serial = value; }
        }
        public string Length
        {
            get { return length; }
            set { length = value; }
        }
        public string Width
        {
            get { return width; }
            set { width = value; }
        }
        public string Height
        {
            get { return height; }
            set { height = value    ; }
        }
        public string Material
        {
            get { return material; }
            set { material = value; }
        }
        public List<Bird>? Birds
        {
            get { return birds; }
        }
        public bool AddBird(Bird bird)
        {
            if (bird != null)
            {
                birds.Add(bird);
                return true;
            }
            return false;
        }
    }
}
