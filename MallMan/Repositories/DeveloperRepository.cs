using MallMan.MVVM.Model;
using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Windows.Media.Imaging;
using MallMan.Core;

namespace MallMan.Repositories
{
    class DeveloperRepository : RepositoryBase, IDeveloperRepository
    {
        public DeveloperModel GetByMail(string mail)
        {
            DeveloperModel devModel = new DeveloperModel();
            using (var connection = GetConnection())
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * from developers where DeveloperMail = @mail;";
                command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = mail;
                MySqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    devModel.DeveloperName = (reader["DeveloperName"].GetType() != typeof(DBNull))?(string)reader["DeveloperName"]: "";
                    devModel.DeveloperMail = (reader["DeveloperMail"].GetType() != typeof(DBNull))?(string)reader["DeveloperMail"]: "";
                    devModel.DeveloperCV = (reader["DeveloperCV"].GetType() != typeof(DBNull))?(string)reader["DeveloperCV"]: "";
                    devModel.DeveloperImage = (reader["developerImage"].GetType() != typeof(DBNull)) ? Extensions.ImageFromBuffer((byte[])reader["DeveloperImage"]) : null;
                }
                return devModel;
            }
        }
    }
}
