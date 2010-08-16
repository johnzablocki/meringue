using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Norm;
using Meringue.Core.Extensions;

namespace Meringue.Models {
    public class MongoServer {

        private readonly string _connectionString = null;

        public MongoServer() {

            //TODO: obviously shouldn't be localhost only
            _connectionString = "mongodb://localhost/admin";
        }

        public IList<string> GetDatabases() {

            using (IMongo mongo = Mongo.Create(_connectionString)) {

                List<string> databases = new List<string>();
                using (MongoAdmin admin = new MongoAdmin(_connectionString)) {
                    admin.GetAllDatabases().ForEach(d => databases.Add(d.Name));
                }

                return databases;                
            }

        }
    }
}
