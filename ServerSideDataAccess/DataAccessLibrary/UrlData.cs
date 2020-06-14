using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class UrlData
    {
        private readonly ISqlDataAccess _db;

        public UrlData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<UrlModel>> GetUrl()
        {
            string sql = "select * from dbo.Url";


        }
    }
}
