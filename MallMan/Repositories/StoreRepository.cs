using MallMan.Core;
using MallMan.MVVM.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallMan.Repositories
{
    class StoreRepository : RepositoryBase, IStoreRepository
    {
        private static StoreModel _currentAccount;
        public static StoreModel CurrentAccount
        {
            get { return _currentAccount; }
            set { _currentAccount = value; }
        }
        public bool AuthenticateStore(int id, string password)
        {
            bool validStore = false;
            using (var connection = GetConnection())
            using (var command = new MySqlCommand())
            {
                Extensions.Test(() =>
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM stores where StoreID = @storeID and StorePassword = @storePassword;";
                    command.Parameters.Add("@storeID", MySqlDbType.Int32).Value = id;
                    command.Parameters.Add("@storePassword", MySqlDbType.VarChar).Value = password;
                    validStore = command.ExecuteScalar() == null ? false : true;
                    CurrentAccount = validStore ? GetById(id) : null;
                });
            }
            return validStore;
        }
        public void Add(StoreModel model)
        {
            Extensions.Test(()=>
            {
                using (var connection = GetConnection())
                {
                    MySqlCommand command = new MySqlCommand();
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO stores (StoreName, OwnerName, StorePassword, StoreImage, MallID) VALUES (@StoreName, @OwnerName, @StorePassword, @StoreImage, @MallID);";
                    command.Parameters.Add("@StoreName", MySqlDbType.VarChar).Value = model.StoreName;
                    command.Parameters.Add("@OwnerName", MySqlDbType.VarChar).Value = model.OwnerName;
                    command.Parameters.Add("@StorePassword", MySqlDbType.VarChar).Value = model.StorePassword;
                    command.Parameters.Add("@StoreImage", MySqlDbType.LongBlob).Value = Extensions.ImageSourceToBytes(model.Image);
                    command.Parameters.Add("@MallID", MySqlDbType.Int32).Value = model.MallID;
                    command.ExecuteNonQuery();
                }
            });
        }

        public void Edit(StoreModel model)
        {
            Extensions.Test(() =>
            {
                using (var connection = GetConnection())
                {
                    MySqlCommand command = new MySqlCommand();
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "Update stores SET(StoreName=@StoreName, OwnerName=@OwnerName, StorePassword=@StorePassword, StoreImage=@StoreImage) WHERE StoreID = @StoreID;";
                    command.Parameters.Add("@StoreName", MySqlDbType.VarChar).Value = model.StoreName;
                    command.Parameters.Add("@OwnerName", MySqlDbType.VarChar).Value = model.OwnerName;
                    command.Parameters.Add("@StorePassword", MySqlDbType.VarChar).Value = model.StorePassword;
                    command.Parameters.Add("StoreImage", MySqlDbType.LongBlob).Value = model.Image;
                    command.Parameters.Add("@StoreID", MySqlDbType.Int32).Value = model.StoreID;
                    command.ExecuteNonQuery();
                }
            });
        }

        public StoreModel GetById(int id)
        {
            StoreModel model = new StoreModel();
            Extensions.Test(() =>
            {
                MySqlCommand command = new MySqlCommand();
                using (var connection = GetConnection())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "Select * FROM stores where StoreID = @storeID";
                    command.Parameters.Add("@storeID", MySqlDbType.Int32).Value = id;
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        model.StoreID = (reader["StoreID"].GetType() != typeof(DBNull)) ? (int)reader["StoreID"] : 0;
                        model.StoreName = (reader["StoreName"].GetType() != typeof(DBNull)) ? (string)reader["StoreName"] : "";
                        model.OwnerName = (reader["OwnerName"].GetType() != typeof(DBNull)) ? (string)reader["OwnerName"] : "";
                        model.StorePassword = (reader["StorePassword"].GetType() != typeof(DBNull)) ? (string)reader["StorePassword"] : "";
                        model.Image = (reader["StoreImage"].GetType() != typeof(DBNull)) ? Extensions.ImageFromBuffer((byte[])reader["StoreImage"]) : null;
                    }
                }
            });
            return model;
        }

        public List<StoreModel> GetList(int mallID)
        {
            List<StoreModel> result = new List<StoreModel>();
            Extensions.Test(() =>
            {
                using (var connection = GetConnection())
                using (var command = new MySqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM stores WHERE MallID = @storeID;";
                    command.Parameters.Add("@storeID", MySqlDbType.Int32).Value = mallID;
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            StoreModel model = new StoreModel
                            {
                                StoreID = (reader["StoreID"].GetType() != typeof(DBNull)) ? (int)reader["StoreID"] : 0,
                                StoreName = (reader["StoreName"].GetType() != typeof(DBNull)) ? (string)reader["StoreName"] : "",
                                OwnerName = (reader["OwnerName"].GetType() != typeof(DBNull)) ? (string)reader["OwnerName"] : "",
                                StorePassword = (reader["StorePassword"].GetType() != typeof(DBNull)) ? (string)reader["StorePassword"] : "",
                                MallID = (reader["MallID"].GetType() != typeof(DBNull)) ? (int)reader["MallID"] : 0,
                                Image = (reader["StoreImage"].GetType() != typeof(DBNull))? Extensions.ImageFromBuffer((byte[])reader["StoreImage"]) : null
                            };
                            result.Add(model);
                        }
                    }
                }
            });
            return result;
        }

        public void Remove(int id)
        {
            Extensions.Test(()=>
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = connection;
                    command.CommandText = "Delete FROM stores WHERE StoreID = @id";
                    command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                    command.ExecuteNonQuery();
                }
            });
        }
    }
}
