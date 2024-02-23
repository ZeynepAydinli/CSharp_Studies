using System;
using System.Collections.Generic; // List, Dictionary
using System.Collections; // Array List
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace StudyGenerals
{
    public class Program
    {// ref, out  

        public static void Add(params int[] numbers)
        {
            int result = numbers.Sum();
            Console.WriteLine(result);

        }
        enum Gunler
        {
            Pazartesi = 1, Salı, Çarşamba, Perşembe, Cuma = 25, Cumartesi, Pazar
        }

        enum HavaDurumu
        {
            Soğuk = 0,
            Normal = 20,
            Sıcak = 30,
        }
        public static void Main(string[] args)
        {
            // Variables, değişkenler: camelCase ile yazılır

            string message1 = "Hello World";
            double amount = 10000.0;
            bool isAuthenticated = false;
              
 
            // Params
            Add(1, 2, 5, 6, -9, 5);

            // Enum
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Pazar);


            int sıcaklık = -9;
            if (sıcaklık < (int)HavaDurumu.Soğuk)
            {
                Console.WriteLine("Sıcaklık sıfırın altındadır.");
            }
            else if (sıcaklık >= (int)HavaDurumu.Soğuk && sıcaklık <= (int)HavaDurumu.Normal)
            {
                Console.WriteLine("Sıcaklık 0 ile 20 derece arasındadır.");
            }
            else if (sıcaklık > (int)HavaDurumu.Normal && sıcaklık <= (int)HavaDurumu.Sıcak)
            {
                Console.WriteLine("Sıcaklık 21 ile 30 derece arasındadır.");
            }
            else
            {
                Console.WriteLine("Sıcaklık 30 dereceden büyüktür");
            }

            // Input
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Name: " + name);
            Console.Write("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age: " + age);
            Console.Write("Please enter your age: ");
            double age2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Age: " + age2);

            // Exception Handling
            try
            {
                Console.Write("Please enter number: ");
                int num = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.Write("Error is ");
                Console.Write(ex.Message);
            }

            try
            {
                Console.Write("Please enter number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1 / num2);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }

            // Arrays
            // int[] number = new int[5];
            // int[,] number = new int[5,3];

            // Array List 
            ArrayList list = new ArrayList();
            list.Add("Lilly");
            list.Add(2);
            list.Add(true);

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("******** Add Range ********");
            string[] colors = { "red", "yellow", "blue", "white" };
            List<string> animal = new List<string>();
            animal.Add("Cat");
            animal.Add("Dog");

            animal.AddRange(colors);


            foreach (var i in animal)
            {
                Console.WriteLine(i);
            }

            // List
            List<int> list1 = new List<int>();

            // class object
            Customer customer1 = new Customer() {Id = 1, FirstName="Zeynep", LastName="Aydınlı", City="Bursa"};

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Pelte";
            customer2.LastName = "Öztaş";
            customer2.City = "İmzir";

            Customer customer3 = new Customer(3, "Lily", "Aydınlı", "Bursa");

            // List class eklenmesi

            List<Customer> customers = new List<Customer>();

            // customers.Sort(); sıralama
            // customers.Reverse(); küçükten büyüğe sıralama

            // list e kullanıcı ataması
            customers.Add(customer3);

            foreach (var i in customers)
            {
                Console.WriteLine("İsim: " + i.FirstName);
            }

            // Constructor base

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            Console.ReadLine();

        }
    }
}
