using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using Pleasure.Data.Models;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Identity;
using System.Security.Principal;

namespace Pleasure.Data
{

    public class Database
    {
        DatabaseLoggin database_ = new DatabaseLoggin("pleasure");



        public void addUser(string UserName, string Password, string Email)
        {
            var wi = WindowsIdentity.GetCurrent();
            var hasher = new PasswordHasher<WindowsIdentity>();


            UserModels ModelsUser = new UserModels
            {
                UserName = UserName,
                Password = hasher.HashPassword(wi, Password),
                Email = Email,
            };
            database_.InsertRecord("Users", ModelsUser);
        }
        public List<UserModels> getUser()
        {
            List<UserModels> data = database_.LoadTecords<UserModels>("Users");
            return data;
        }
    }
    class DatabaseLoggin
    {
        private IMongoDatabase dataBase { get; set; }

        public DatabaseLoggin(string dataBase)
        {
            MongoClient client = new MongoClient("mongodb+srv://admin:{password}@cluster0.qwuqy.azure.mongodb.net/test");

            this.dataBase = client.GetDatabase(dataBase);


        }
        public List<T> LoadTecords<T>(string table)
        {
            var collection = dataBase.GetCollection<T>(table);
            return collection.Find(new BsonDocument()).ToList();
        }
        public void InsertRecord<T>(string table, T record)
        {
            var collection = dataBase.GetCollection<T>(table);
            collection.InsertOne(record);
        }
    }
}
