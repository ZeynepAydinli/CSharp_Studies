using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace StudyGenerals
{
    public class Customer
    {

        private int _id; // field
        private string _firstname;
        private string _lastname;
        private string _city;
        
        // Default constructor
        public Customer()
        {
            
        }
        public Customer(int id, string firstname, string lastname, string city)
        {
            _id = id;
            _firstname = firstname;
            _lastname = lastname;
            _city = city;
        }

        public int Id { get; set; } // Property
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }

    class BaseClass
    {
        private string _entity;

        public BaseClass(string entity)
        {
            _entity = entity;
        }

        public void Message()
        {
            Console.WriteLine("Message: " + _entity);
        }
    }

    class PersonManager : BaseClass
    {
        public PersonManager(string entity) : base(entity) //*************
        {
            
        }

        public void Add()
        {
            Console.WriteLine("Added");
            Message();
        }
    }
}
