using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using Dumpling_Food.Models;
/// <summary>
/// /////////////////////////// carservices.cs services file
/// </summary>
namespace Dumpling_Food.Services
{
    public class DbServices
    {
        private readonly IMongoCollection<Models.User.LoginModel> LoginData;

        public DbServices(IConfiguration config)
        {
            MongoClient client = new MongoClient(config.GetConnectionString("DumplingDatabase"));
            IMongoDatabase database = client.GetDatabase("DumplingDatabase");
            LoginData = database.GetCollection<Models.User.LoginModel>("Customers");
        }

        public List<Models.User.LoginModel> Get()
        {
            return LoginData.Find(user => true).ToList();
        }

        public Models.User.LoginModel Get(string id)
        {
            return LoginData.Find(user => user.Id == id).FirstOrDefault();
        }

        public Models.User.LoginModel Create(Models.User.LoginModel user)
        {
            LoginData.InsertOne(user);
            return user;
        }

        public void Update(string id, Models.User.LoginModel userIn)
        {
            LoginData.ReplaceOne(user => user.Id == id, userIn);
        }

        public void Remove(Models.User.LoginModel userIn)
        {
            LoginData.DeleteOne(user => user.Id == userIn.Id);
        }

        public void Remove(string id)
        {
            LoginData.DeleteOne(user => user.Id == id);
        }
    }
}
