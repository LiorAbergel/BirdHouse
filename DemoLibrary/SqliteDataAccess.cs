using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Globalization;
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
                if (columnName == "HatchDate")
                    filter += " 00:00:00";

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

        public static Cage GetCage(string cageSerial)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@cageSerial", cageSerial);

                var output = cnn.QueryFirstOrDefault<Cage>("SELECT * FROM Cages WHERE Serial = @cageSerial LIMIT 1", parameters);
                return output;
            }
        }

        public static Bird GetBird(string birdSerial)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@birdSerial", birdSerial);

                var output = cnn.QueryFirstOrDefault<Bird>("SELECT * FROM Birds WHERE serial = @birdSerial LIMIT 1", parameters);
                return output;
            }
        }

        public static void SetCage(string cageSerial, Cage newCage)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Serial", newCage.Serial);
                parameters.Add("@Length", newCage.Length);
                parameters.Add("@Width", newCage.Width);
                parameters.Add("@Height", newCage.Height);
                parameters.Add("@cageSerial", cageSerial);

                cnn.Execute("UPDATE Cages SET Serial = @Serial, Length = @Length, Width = @Width, Height = @Height WHERE Serial = @cageSerial", parameters);
            }
        }

        public static void SetBird(string birdSerial, Bird newBird)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@serial", newBird.Serial);
                parameters.Add("@specie", newBird.Specie);
                parameters.Add("@subSpecie", newBird.SubSpecie);
                parameters.Add("@hatchDate", newBird.HatchDate);
                parameters.Add("@gender", newBird.Gender);
                parameters.Add("@cageSerial", newBird.CageSerial);
                parameters.Add("@fatherSerial", newBird.FatherSerial);
                parameters.Add("@motherSerial", newBird.MotherSerial);
                parameters.Add("@birdSerial", birdSerial);

                cnn.Execute("UPDATE Birds SET serial = @serial, specie = @specie, subSpecie = @subSpecie, hatchDate = @hatchDate, gender = @gender," +
                    " cageSerial = @cageSerial, fatherSerial = @fatherSerial, motherSerial = @motherSerial WHERE serial = @birdSerial", parameters);
            }
        }

        public static bool IsBirdSerialExist(string ownerID, string birdSerial)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand("SELECT COUNT(*) FROM Birds " +
                    "INNER JOIN Cages ON Birds.cageSerial = Cages.Serial " +
                    "WHERE Birds.serial = @birdSerial AND Cages.OwnerId = @ownerId", connection))
                {
                    command.Parameters.AddWithValue("@birdSerial", birdSerial);
                    command.Parameters.AddWithValue("@ownerId", ownerID);
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        public static bool IsCageSerialExist(string ownerID, string cageSerial)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand("SELECT COUNT(*) FROM Cages " +
                    "WHERE Serial = @cageSerial AND ownerId = @ownerId", connection))
                {
                    command.Parameters.AddWithValue("@cageSerial", cageSerial);
                    command.Parameters.AddWithValue("@ownerId", ownerID);
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        public static void ChangeBirdsCageSerial(string oldCageSerial, string newCageSerial)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand("UPDATE Birds SET cageSerial = @newCageSerial WHERE cageSerial = @oldCageSerial", connection))
                {
                    command.Parameters.AddWithValue("@newCageSerial", newCageSerial);
                    command.Parameters.AddWithValue("@oldCageSerial", oldCageSerial);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static List<string> GetHatchDatesByOwnerID(string ownerID)
        {
            List<string> hatchDates = new List<string>();

            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand("SELECT hatchDate FROM Birds " +
                                                                 "INNER JOIN Cages ON Birds.cageSerial = Cages.Serial " +
                                                                 "WHERE Cages.ownerId = @ownerId", connection))
                {
                    command.Parameters.AddWithValue("@ownerId", ownerID);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime hatchDate = reader.GetDateTime(0);
                            string hatchDateString = hatchDate.ToString("yyyy-MM-dd"); // Format the date as desired
                            hatchDates.Add(hatchDateString);
                        }
                    }
                }
            }

            return hatchDates.Distinct().ToList();
        }








    }
}
