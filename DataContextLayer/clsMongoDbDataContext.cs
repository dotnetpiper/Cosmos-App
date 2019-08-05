using DataContextLayer.AppConfig;
using Microsoft.Extensions.Configuration;
using ModelClass;
using MongoDB.Driver;

namespace DataContextLayer
{
    public class clsMongoDbDataContext
    {
        private string _connectionStrings = string.Empty;
        private string _databaseName = string.Empty;
        private string _collectionName = string.Empty;
        

        private readonly IMongoClient _client;
        private readonly IMongoDatabase _database;

        public clsMongoDbDataContext(string strCollectionName)
        {
            this._collectionName = strCollectionName;
            this._connectionStrings = AppConfiguration.GetConfiguration("ServerName");
            this._databaseName = AppConfiguration.GetConfiguration("DatabaseName");
            this._client = new MongoClient(_connectionStrings);
            this._database = _client.GetDatabase(_databaseName);
        }

        public IMongoClient Client
        {
            get { return _client; }
        }

        public IMongoDatabase Database
        {
            get { return _database; }
        }

        public IMongoCollection<Product> GetProducts
        {
            get { return _database.GetCollection<Product>(_collectionName); }
        }
    }
}
