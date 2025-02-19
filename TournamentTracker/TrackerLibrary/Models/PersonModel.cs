using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// the unique Id number of the person
        /// </summary>
        public int Id { get; set; }
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

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
