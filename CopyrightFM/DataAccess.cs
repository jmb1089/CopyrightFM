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

        /// <summary>
        /// Finds a person given a last name
        /// </summary>
        /// <param name="lastName">last name to look up </param>
        /// <returns>a list containing people found from a given last name </returns>
        public List<Person> GetPeople(string lastName)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CNN("CustomerApplicationDB")))
            {
               var found =  connection.Query<Person>($"select * from Customer where LastName = '{lastName}' or where FirstName = '{lastName}'").ToList();
               return found;
            }
            
        }



        /// <summary>
        /// finds all people in the data base and returns it as a person list 
        /// </summary>
        /// <returns>a list containing all people found</returns>
        public List<Person> AllApplicants()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CNN("CustomerApplicationDB")))
            {
                var found = connection.Query<Person>($"select * from CUstomer").ToList();
                return found;
            }
        }
    }
}
