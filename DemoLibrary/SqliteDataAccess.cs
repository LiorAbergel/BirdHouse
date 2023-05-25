using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
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
                parameters.Add("@ownerID", ownerID); // Add the ownerID parameter

                var output = cnn.Query<Cage>("select * from Cages where ownerID = @ownerID", parameters);
                return output.ToList();
            }
        }
        public static void saveCage(Cage cage)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Cages (ownerID,Serial,Length,Width,Height,Material) values (@ownerID,@Serial,@Length,@Width,@Height,@Material)", cage);
            }
        }

        private static string LoadConnectionString(string id = "Default") {

            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
