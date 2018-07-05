using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace CopyrightFM
{
    public class DataAccess
    {
        public List<Person> GetPeople(string lastName)
        {
           
            
            
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CNN("CustomerApplicationDB")))
            {
               var found =  connection.Query<Person>($"select * from Customer where LastName = '{lastName}'").ToList();
                return found;
            }
            
        }
    }
}
