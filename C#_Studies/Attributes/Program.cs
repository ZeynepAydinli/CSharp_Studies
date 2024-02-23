using Attributes;

Customer customer1 = new Customer
{
    Id = 1,
    FirstName = "Zeynep",
    LastName = "Aydınlı",
    Age = 5,
};

CustomerDal customerDal = new CustomerDal();

customerDal.Add(customer1);

Console.ReadLine();


