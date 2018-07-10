using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyrightFM
{
    public class Person
    {
        /// <summary>
        /// Gets the first name
        /// </summary>
        public string FirstName
        {
            get;
        }

        public string Lastname
        {
            get;
        }
        
        public int OrderID
        {
            get;
        }

        public int Date
        {
            get;
        }

        public string Initial
        {

            get;
        }

        public string Release
        {

            get;
        }
        public string FullInfo
        {

            get
            {
                return $"{FirstName} {Lastname} OrderID: {OrderID}";
            }
        }
        
    }
}
