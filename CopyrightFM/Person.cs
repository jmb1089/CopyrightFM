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
        
        public long OrderID
        {
            get;
        }

        public string DateS
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

        public long PhoneNum
        { get; }
        
        public string FullInfo
        {

            get
            {
                return $"{FirstName} {Lastname} OrderID: {OrderID}";
            }
        }
        
    }
}
