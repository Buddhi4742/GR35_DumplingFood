//using MongoDB.Driver;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using MongoDB.Bson;

//namespace Dumpling_Food.Controllers.Database
//{
//    public class MongoCRUD
//    {
//        private IMongoDatabase db; 

//        public MongoCRUD(string dbname)
//        {
//            MongoClientSettings settings = MongoClientSettings.FromConnectionString("CONNECTION_STRING");
//            MongoClient client = new MongoClient(settings);
//            IMongoDatabase database = client.GetDatabase("DumplingFood");
//        }
//    }
//}
