using MallMan.Core;
using MallMan.MVVM.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace MallMan.Repositories
{
    class MallRepository : RepositoryBase, IMallRepository
    {
        public void Add(MallModel adminCityModel)
        {
            Extensions.Test(() =>
            {
                using(var connection = GetConnection())
                using(var command = new MySqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO (AdminID, CityCode, StoreCount) VALUES (@adminID, @CityCode, @storeCount);";
                    command.Parameters.Add("@adminID", MySqlDbType.Int32).Value = adminCityModel.AdminID;
                    command.Parameters.Add("@cityCode", MySqlDbType.VarChar).Value = adminCityModel.CityCode;
                    command.Parameters.Add("@storeCount", MySqlDbType.Int32).Value = adminCityModel.StoreCount;
                    command.ExecuteNonQuery();
                }
            });
        }

        public List<MallModel> GetList(int adminID)
        {
            List<MallModel> result = new List<MallModel>();
            Extensions.Test(()=>
            {
                using(var connection = GetConnection())
                using(var command = new MySqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM malls WHERE adminID = @adminID;";
                    command.Parameters.Add("@adminID", MySqlDbType.Int32).Value = adminID;
                    using(var reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            MallModel model = new MallModel
                            {
                                MallID = (reader["MallID"].GetType() != typeof(DBNull)) ? (int)reader["MallID"] : 0,
                                AdminID = (reader["AdminID"].GetType() != typeof(DBNull)) ? (int)reader["AdminID"] : 0,
                                CityCode = (reader["CityCode"].GetType() != typeof(DBNull)) ? (string)reader["CityCode"] : "",
                                StoreCount = (reader["StoreCount"].GetType() != typeof(DBNull)) ? (int)reader["StoreCount"] : 0
                            };
                            result.Add(model);
                        }
                    }
                }
            });
            return result;
        }

        public void Remove(int mallID)
        {
            Extensions.Test(()=>
            {
                using (var connection = GetConnection())
                using (var command = new MySqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM admincities where AdminCityID = @id;";
                    command.Parameters.Add("@id", MySqlDbType.Int32).Value = mallID;
                    command.ExecuteNonQuery();
                }
            });
        }
    }
}
