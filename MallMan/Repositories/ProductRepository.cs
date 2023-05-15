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
    class ProductRepository : RepositoryBase, IProductRepository
    {
        public void Add(ProductModel model)
        {
            Extensions.Test(()=>
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    var command = new MySqlCommand();
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO products(ProductID, StoreID, ProductName, ProductAmount, ProductPrice, ProductImage, ProductInfo) VALUES (@productID, @storeID, @productName, @productAmount, @productPrice, @productImage, @productInfo);";
                    command.Parameters.Add("@productID", MySqlDbType.Int32).Value = model.ProductID;
                    command.Parameters.Add("@storeID", MySqlDbType.Int32).Value = model.StoreID;
                    command.Parameters.Add("@productName", MySqlDbType.VarChar).Value = model.ProductName;
                    command.Parameters.Add("@productAmount", MySqlDbType.Int32).Value = model.ProductAmount;
                    command.Parameters.Add("@productPrice", MySqlDbType.Float).Value = model.ProductPrice;
                    command.Parameters.Add("@productImage", MySqlDbType.LongBlob).Value = Extensions.ImageSourceToBytes(model.ProductImage);
                    command.Parameters.Add("@productInfo", MySqlDbType.VarChar).Value = model.ProductInfo;
                    command.ExecuteNonQuery();
                }
            });
        }

        public ProductModel GetById(int id)
        {
            var model = new ProductModel();
            Extensions.Test(()=>
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    var command = new MySqlCommand();
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM products WHERE ProductID = @productID;";
                    command.Parameters.Add("@productID", MySqlDbType.Int32).Value = id;
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        model.ProductID = (reader["ProductID"].GetType() != typeof(DBNull)) ? (int)reader["ProductID"] : 0;
                        model.StoreID = (reader["StoreID"].GetType() != typeof(DBNull)) ? (int)reader["StoreID"] : 0;
                        model.ProductName = (reader["ProductName"].GetType() != typeof(DBNull)) ? (string)reader["ProductName"] : "";
                        model.ProductAmount = (reader["ProductAmount"].GetType() != typeof(DBNull)) ? (int)reader["ProductAmount"] : 0;
                        model.ProductPrice = (reader["ProductPrice"].GetType() != typeof(DBNull)) ? (float)reader["ProductPrice"] : 0;
                        model.ProductImage = (reader["ProductImage"].GetType() != typeof(DBNull)) ? Extensions.ImageFromBuffer((byte[])reader["ProductImage"]) : null;
                        model.ProductInfo = (reader["ProductInfo"].GetType() != typeof(DBNull)) ? (string)reader["ProductInfo"] : "";
                    }
                }
            });
            return model;
        }

        public List<ProductModel> GetList(int storeID)
        {
            List<ProductModel> result = new List<ProductModel>();
            Extensions.Test(() =>
            {
                using (var connection = GetConnection())
                using (var command = new MySqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM products WHERE StoreID = @storeID;";
                    command.Parameters.Add("@storeID", MySqlDbType.Int32).Value = storeID;
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ProductModel model = new ProductModel
                            {
                                ProductID = (reader["ProductID"].GetType() != typeof(DBNull)) ? (int)reader["ProductID"] : 0,
                                StoreID = (reader["StoreID"].GetType() != typeof(DBNull)) ? (int)reader["StoreID"] : 0,
                                ProductName = (reader["ProductName"].GetType() != typeof(DBNull)) ? (string)reader["ProductName"] : "",
                                ProductAmount = (reader["ProductAmount"].GetType() != typeof(DBNull)) ? (int)reader["ProductAmount"] : 0,
                                ProductPrice = (reader["ProductPrice"].GetType() != typeof(DBNull)) ? (float)reader["ProductPrice"] : 0,
                                ProductImage = (reader["ProductImage"].GetType() != typeof(DBNull)) ? Extensions.ImageFromBuffer((byte[])reader["ProductImage"]) : null,
                                ProductInfo = (reader["ProductInfo"].GetType() != typeof(DBNull)) ? (string)reader["ProductInfo"] : ""
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
                using(var command = new MySqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM products WHERE productID = @productID;";
                    command.Parameters.Add("@productID", MySqlDbType.Int32).Value = id;
                    command.ExecuteNonQuery();
                }
            });
        }

        public void Update(ProductModel model)
        {
            Extensions.Test(()=>
            {
                using (var connection = GetConnection())
                using (var command = new MySqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "UPDATE products SET ProductName = @productName, ProductAmount = @productAmount, ProductPrice = @productPrice, ProductImage = @productImage, ProductInfo = @productInfo WHERE ProductID = @productID;";
                    //command.Parameters.Add("@storeID", MySqlDbType.Int32).Value = model.StoreID;
                    command.Parameters.Add("@productName", MySqlDbType.VarChar).Value = model.ProductName;
                    command.Parameters.Add("@productAmount", MySqlDbType.Int32).Value = model.ProductAmount;
                    command.Parameters.Add("@productPrice", MySqlDbType.Float).Value = model.ProductPrice;
                    command.Parameters.Add("@productImage", MySqlDbType.LongBlob).Value = Extensions.ImageSourceToBytes(model.ProductImage);
                    command.Parameters.Add("@productID", MySqlDbType.Int32).Value = model.ProductID;
                    command.Parameters.Add("@productInfo", MySqlDbType.VarChar).Value = model.ProductInfo;
                    command.ExecuteNonQuery();
                }
            });
        }
    }
}
