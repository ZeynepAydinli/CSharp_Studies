// Inheritance -- Value and Reference Type

//Value Type (Değer Tip): int, double, enum, bool. Sadece Stack kısmında oluşur.

using System;
using Value_Reference_Type;

int number1 = 10;
int number2 = 20;

number1 = number2;

number2 = 100;

Console.WriteLine("Sayı 1: " + number1);

// Reference Type: Array, class, interface, abstract, string(ama değer tip gibi çalışır). 
//                 Stack ve Heap kısımlarında oluşur. New denildiği zaman heap kısmında veri oluşur.

int[] numbers3 = new int[] { 1, 2, 3, 4 };
int[] numbers4 = new int[] { 10, 20, 30, 40 };

numbers3 = numbers4;

numbers4[0] = 1000;

Console.WriteLine("Numbers3[0]: " + numbers3[0]);


// Class, reference type

BasePerson person1 = new BasePerson();
BasePerson person2 = new BasePerson();

person1.FirstName = "Zeynep";
person2 = person1;

person1.FirstName = "Pelte";

Console.WriteLine(person2.FirstName);


Customer customer1 = new Customer();
customer1.FirstName = "Lily";
customer1.CreditCardNumber = "123456789";

BasePerson person3 = customer1; // Inheritance da base sınıf ataması yapılabilir.
                                // Direk neden customer'dan gidilmediğini PersonManager sınıfında anlatıldı

Console.WriteLine(person3.FirstName);

Console.WriteLine(((Customer)person3).CreditCardNumber); // person3 diyince credit card number çıkmaz
                                                         // customer parantezine alınca çıkar. 

PersonManager personManager = new PersonManager();
personManager.Add(customer1);


Customer person4 = new Customer();
person4.Id = 4;
person4.FirstName = "Zeynep";
person4.LastName = "Aydınlı";
person4.CreditCardNumber = "12345";

Customer person5 = new Customer();
person5.Id = 5;
person5.FirstName = "Burak";
person5.LastName = "Öztaş";
person5.CreditCardNumber = "45678";

Employee person6 = new Employee();
person6.Id = 6;
person6.FirstName = "Lily";
person6.LastName = "British Shorthair";
person6.EmployeeNumber = 1;

Employee person7 = new Employee();
person7.Id = 7;
person7.FirstName = "Pelte";
person7.LastName = "Tekir";
person7.EmployeeNumber = 2;

//                        101       102      103      104
BasePerson[] persons = { person4, person5, person6, person7 };

// Polymorphism
foreach (BasePerson person in persons)
{
    Console.WriteLine(person.FirstName + " " + person.LastName);

    if (person is Customer)
    {
        Console.WriteLine(((Customer)person).CreditCardNumber);
    }    
}




