using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RentMeFurnitureRentalSystem.Model
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public DateTime RegistrationDate { get; set; }

        public Customer()
        {
        }
        
        public void FillCommand(MySqlCommand query)
        {
            query.Parameters.Add("@fname", MySqlDbType.VarChar).Value = this.FirstName;
            query.Parameters.Add("@lname", MySqlDbType.VarChar).Value = this.LastName;
            query.Parameters.Add("@dob", MySqlDbType.DateTime).Value = this.Birthday;
            query.Parameters.Add("@gender", MySqlDbType.VarChar).Value = this.Gender;
            query.Parameters.Add("@email", MySqlDbType.VarChar).Value = this.Email;
            query.Parameters.Add("@phone", MySqlDbType.VarChar).Value = this.Phone;
            query.Parameters.Add("@address", MySqlDbType.VarChar).Value = this.StreetAddress;
            query.Parameters.Add("@city", MySqlDbType.VarChar).Value = this.City;
            query.Parameters.Add("@state", MySqlDbType.VarChar).Value = this.State;
            query.Parameters.Add("@zip", MySqlDbType.VarChar).Value = this.Zipcode;
        }
    }
}
