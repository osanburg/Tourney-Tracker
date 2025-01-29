using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PersonModel
    {
        /// <summary>
        /// the first name of this person
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// the last name of this person
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// the email address of this person
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// the cellphone number of this person
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
