using Repositories.DB.Interfaces;
using Repositories.DB.QueryBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Core.Dumps
{
    public class FakeDBConnection : IDBConnection
    {

        public long Insert(string sql, Dictionary<string, dynamic> arguments = null)
        {
            return 1;
        }

        public void Update(string sql, Dictionary<string, dynamic> arguments = null)
        {

        }

        public List<dynamic> Query(string sql, List<QueryWhere> arguments = null)
        {
            return new List<dynamic>();
        }

    }
}
