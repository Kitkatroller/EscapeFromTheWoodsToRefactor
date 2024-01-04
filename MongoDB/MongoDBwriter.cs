using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;

namespace EscapeFromTheWoods.MongoDB
{
    public class MongoDBwriter
    {
        private IMongoDatabase database;

        public MongoDBwriter(string connectionString)
        {
            var client = new MongoClient(connectionString);
            this.database = client.GetDatabase("EscapeFromTheWoodsDB");
        }

        public void WriteMonkeyRecords(List<DBMonkeyRecord> data)
        {
            var collection = database.GetCollection<DBMonkeyRecord>("monkeys");
            foreach (var record in data)
            {
                collection.InsertOne(record);
            }
        }

        public void WriteWoodRecords(List<DBWoodRecord> data)
        {
            var collection = database.GetCollection<DBWoodRecord>("woods");
            foreach (var record in data)
            {
                collection.InsertOne(record);
            }
        }

        public void WriteLogRecords(List<DBLogRecord> data)
        {
            var collection = database.GetCollection<DBLogRecord>("Logs");
            foreach (var record in data)
            {
                collection.InsertOne(record);
            }
        }
    }
}
