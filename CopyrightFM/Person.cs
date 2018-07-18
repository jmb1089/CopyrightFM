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
            set;
        }

        public string Lastname
        {
            get;
            set;
        }
        
        public long OrderID
        {
            get;
            set;
        }

        public string DateS
        {
            get;
            set;
        }

        public string Initial
        {

            get;
            set;
        }

        public string Release
        {

            get;
            set;
        }

        public long PhoneNum
        { get; set; }
        
        public string FullInfo
        {

            get
            {
                return $"{FirstName} {Lastname} OrderID: {OrderID}";
            }
        }
        
    }
}
