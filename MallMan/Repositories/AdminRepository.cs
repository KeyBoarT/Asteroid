using MallMan.Core;
using MallMan.MVVM.Model;
using MySql.Data.MySqlClient;
using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace MallMan.Repositories
{
    public class AdminRepository : RepositoryBase, IAdminRepository
    {
        private static AdminModel _currentAccount;
        public static AdminModel CurrentAccount
        {
            get { return _currentAccount; }
            set { _currentAccount = value; }
        }
        public void Add(AdminModel adminModel)
        {
            
        }

        public bool AuthenticateAdmin(int id, string password)
        {
            bool validAdmin = false;
            using (var connection = GetConnection())
            using (var command = new MySqlCommand())
            {
                Extensions.Test(()=>
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM admins where adminID = @adminID and adminPassword = @adminPassword;";
                    command.Parameters.Add("@adminID", MySqlDbType.Int32).Value = id;
                    command.Parameters.Add("@adminPassword", MySqlDbType.VarChar).Value = password;
                    validAdmin = command.ExecuteScalar() == null ? false : true;
                    CurrentAccount = validAdmin ? GetById(id) : null;
                });
            }
            return validAdmin;
        }

        public void Edit(AdminModel adminModel)
        {
            using (var connection = GetConnection())
            using (var command = new MySqlCommand())
            {
                Extensions.Test(()=>
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "UPDATE admins SET AdminName = @name, AdminPassword = @pass, AdminEmail = @email, AdminImage = @image WHERE adminID = @adminID;";
                    command.Parameters.Add("@adminID", MySqlDbType.Int32).Value = adminModel.AdminID;
                    command.Parameters.Add("@name", MySqlDbType.VarChar).Value = adminModel.AdminName;
                    command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = adminModel.AdminPassword;
                    command.Parameters.Add("@email", MySqlDbType.VarChar).Value = adminModel.AdminEmail;
                    command.Parameters.Add("@image", MySqlDbType.LongBlob).Value = Extensions.ImageSourceToBytes(adminModel.AdminImage);
                    command.ExecuteNonQuery();
                });
            }
        }

        public AdminModel GetByAdminEmail(string adminEmail)
        {
            AdminModel model = new AdminModel();
            Extensions.Test(()=>
            {
                using(var connection = GetConnection())
                using(var command = new MySqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM admin where AdminEmail = @email;";
                    command.Parameters.Add("@email", MySqlDbType.VarChar).Value = adminEmail;
                    using(var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            model.AdminID = (reader["AdminID"].GetType() != typeof(DBNull)) ? (int)reader["AdminID"] : 0;
                            model.AdminName = (reader["AdminName"].GetType() != typeof(DBNull)) ? (string)reader["AdminName"] : "";
                            model.AdminEmail = (reader["AdminEmail"].GetType() != typeof(DBNull)) ? (string)reader["AdminEmail"] : "";
                            model.AdminPassword = (reader["AdminPassword"].GetType() != typeof(DBNull)) ? (string)reader["AdminPassword"] : "";
                            model.AdminImage = (reader["AdminImage"].GetType() != typeof(DBNull)) ? Extensions.ImageFromBuffer((byte[])reader["AdminImage"]): null;
                        }
                    }
                }
            });
            return model;
        }

        public AdminModel GetById(int id)
        {
            AdminModel adminModel = new AdminModel();
            using (var connection = GetConnection())
            using (var command = new MySqlCommand())
            {
                Extensions.Test(() =>
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM admins where adminID = @admin";
                    command.Parameters.Add("@admin", MySqlDbType.Int32).Value = id;
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            adminModel.AdminID = (reader["AdminID"].GetType() != typeof(DBNull)) ? (int)(reader["AdminID"]) : 0;
                            adminModel.AdminName = (reader["AdminName"].GetType() != typeof(DBNull)) ? (string)(reader["AdminName"]) : "";
                            adminModel.AdminPassword = (reader["AdminPassword"].GetType() != typeof(DBNull)) ? (string)(reader["AdminPassword"]) : "";
                            adminModel.AdminEmail = (reader["AdminEmail"].GetType() != typeof(DBNull)) ? (string)(reader["AdminEmail"]) : "";
                            adminModel.AdminImage = (reader["AdminImage"].GetType() != typeof(DBNull)) ? Extensions.ImageFromBuffer((byte[])reader["AdminImage"]) : null;
                        }
                    }
                });
            }
            return adminModel;
        }
        public void Remove(int id)
        {
        }
    }
}
