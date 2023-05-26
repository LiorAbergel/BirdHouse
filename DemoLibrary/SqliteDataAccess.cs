﻿using Dapper;
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

        public static List<Cage> SearchCages(string filter, string columnName)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@filter", filter); // Add the filter parameter

                string query = $"SELECT * FROM Cages WHERE {columnName} = @filter";
                var output = cnn.Query<Cage>(query, parameters);
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
                parameters.Add("@cageSerial", cageSerial); // Add the ownerID parameter
                var output = cnn.Query<Bird>($"select * from Birds where cageSerial = @cageSerial",parameters);
                return output.ToList();
            }
        }

        public static List<Bird> SearchBirds(string filter, string columnName)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {

                var parameters = new DynamicParameters();
                parameters.Add("@filter", filter); // Add the filter parameter

                string query = $"SELECT * FROM Birds WHERE {columnName} = @filter";
                var output = cnn.Query<Bird>(query, parameters);
                return output.ToList();
            }
        }

        public static List<string> GetParentsSerials(string cageSerial, string subSpecie, string gender)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@cageSerial", cageSerial);
                parameters.Add("@subSpecie", subSpecie);
                parameters.Add("@gender", gender);

                string query = $"SELECT * FROM Birds WHERE cageSerial = @cageSerial AND subSpecie = @subSpecie AND gender = @gender";
                var output = cnn.Query<string>(query, parameters);
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

            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
