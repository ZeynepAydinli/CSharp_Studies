using InterfaceStudy.Abstract;
using InterfaceStudy;

PersonManager personManager = new PersonManager();

IPerson person = new Customer
{
    Id = 1,
    FirstName = "Zeynep",
    LastName = "Aydınlı",
    Address = "Bursa",
};

IPerson person2 = new Student
{
    Id = 1,
    FirstName = "Lily",
    LastName = "British",
    Departmant = "Kedi",
};

personManager.Add(person);
personManager.Add(person2);

IPerson[] people = new IPerson[2]  // Bu durum daha çok database için kullanılır.
{
    new Customer{FirstName = "Zeynep"},
    new Student{FirstName = "Lily"}
};

foreach (var _person in people)
{
    Console.WriteLine(_person.FirstName);
}

Console.ReadLine();


