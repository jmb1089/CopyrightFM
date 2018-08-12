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
               var found =  connection.Query<Person>($"select * from Customer where LastName = '{lastName}'").ToList();
               return found;
            }
            
        }

        public void AddUser(string firstName, string lastName, string orderID, string date, string initial, string phoneNum)
        {

            using (SqlConnection conn = new SqlConnection(Helper.CNN("CustomerApplicationDB")))
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Customer (FirstName, LastName, OrderID, DateS, Initial, PhoneNum) VALUES ( @FirstName, @LastName, @OrderID, @DateS, @Initial, @PhoneNum)", conn);
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;


                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@OrderID", orderID);
                cmd.Parameters.AddWithValue("@DateS", date);
                cmd.Parameters.AddWithValue("@Initial", initial);
                cmd.Parameters.AddWithValue("@PhoneNum", phoneNum);

                cmd.ExecuteNonQuery();
                conn.Close();

            }

            //using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CNN("CustomerApplicationDB")))
            
                //Person newCustomer = new Person { FirstName = firstName, Lastname = lastName, OrderID = orderID, DateS = date, Initial = initial, PhoneNum = phoneNum };
                //List<Person> customer = new List<Person>();
                //customer.Add(new Person { FirstName = firstName, Lastname = lastName, OrderID = Int64.Parse(orderID), DateS = date, Initial = initial, PhoneNum = Int64.Parse(phoneNum) });
                //connection.Execute("dbo.People_Insert @FirstName, @LastName, @OrderID, @DateS, @Initial, @PhoneNum", customer);

                
            
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
