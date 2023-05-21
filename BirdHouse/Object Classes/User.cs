namespace BirdHouse.Object_Classes
{
    internal class User
    {
        private string userName;
        private string password;
        private string id;
        private List<Cage> cages;

        public User(string userName, string password, string id)
        {
            this.userName = userName;
            this.password = password;
            this.id = id;
            cages = new List<Cage>();
        }

        public string Username
        {
            get { return userName; }
            set { userName = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public List<Cage> Cages
        {
            get { return cages; }
            set { cages = value; }
        }

        public bool AddCage(Cage cage)
        {
            if (cage != null)
            {
                cages.Add(cage);
                return true;
            }
            return false;
        }
    }
}
