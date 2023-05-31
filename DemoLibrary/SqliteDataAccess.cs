using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;

namespace DemoLibrary
{
    public class SqliteDataAccess
    {
        public static List<Cage> LoadCages(string ownerID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@ownerID", ownerID);

                var output = cnn.Query<Cage>("select * from Cages where ownerID = @ownerID", parameters);
                return output.ToList();
            }
        }

        public static List<Cage> SearchCages(string ownerID, string filter, string columnName)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@ownerID", ownerID);
                parameters.Add("@filter", filter);

                var output = cnn.Query<Cage>($"SELECT * FROM Cages WHERE ownerID = @ownerID AND {columnName} = @filter ORDER BY Serial ASC", parameters);
                return output.ToList();
            }
        }

        public static void SaveCage(Cage cage)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Cages (ownerID,Serial,Length,Width,Height,Material) values (@ownerID,@Serial,@Length,@Width,@Height,@Material)", cage);
            }
        }

        public static List<Bird> LoadBirds(string cageSerial)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@cageSerial", cageSerial);

                var output = cnn.Query<Bird>($"select * from Birds where cageSerial = @cageSerial ORDER BY CAST(Serial AS INTEGER) ASC",parameters);
                return output.ToList();
            }
        }

        public static List<Bird> SearchBirds(string filter, string columnName)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@filter", filter);

                var output = cnn.Query<Bird>($"SELECT * FROM Birds WHERE {columnName} = @filter ORDER BY CAST(Serial AS INTEGER) ASC", parameters);
                return output.ToList();
            }
        }

        public static void SaveBirds(Bird bird)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Birds (serial, specie, subSpecie, hatchDate, gender, cageSerial , fatherSerial, motherSerial) " +
                    "values (@serial, @specie, @subSpecie, @hatchDate, @gender, @cageSerial, @fatherSerial, @motherSerial)", bird);
            }
        }

        private static string LoadConnectionString(string id = "Default") {

            var connectionStringSettings = ConfigurationManager.ConnectionStrings[id];
            var binFolderPath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            var parentFolderPath = Directory.GetParent(binFolderPath).FullName;
            var connectionString = connectionStringSettings.ConnectionString.Replace("|DataDirectory|", parentFolderPath);
            return connectionString;
        }

        public static List<string> GetParentsSerials(string cageSerial, string subSpecie, string gender)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@cageSerial", cageSerial);
                parameters.Add("@subSpecie", subSpecie);
                parameters.Add("@gender", gender);

                var output = cnn.Query<string>($"SELECT * FROM Birds WHERE cageSerial = @cageSerial AND subSpecie = @subSpecie AND gender = @gender", parameters);
                return output.ToList();
            }
        }

    }
}
