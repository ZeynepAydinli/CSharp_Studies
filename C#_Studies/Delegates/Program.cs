using Delegates;

public delegate void MyDelegate();

public delegate void MyDelegate2(string text);

public delegate int MyDelegate3(int number1, int number2);

class Program
{
    // Func 
    static int Add(int x, int y)
    {
        return x + y;
    }

    static void Main(string[] args)
    {
        // Func

        Func<int, int, int> addFunc = Add; //Parametre olduğu zaman birden fazla int yazılır
        Console.WriteLine(addFunc(3, 5));

        Func<int> getRandomNumber = delegate() //Parametresi olmayan metot
        {
            Random random = new Random(); //Random class
            return random.Next(1, 100);
        };
        Console.WriteLine(getRandomNumber());

        Func<int> getRAndomNumber2 = () => new Random().Next(1, 100);
        
        Thread.Sleep(1000); //Uygulama 1 sn bekler
        Console.WriteLine(getRAndomNumber2());

        // Console.WriteLine(Add(2, 3));

        Console.WriteLine("-----------------");

        // Delegate

        CustomerManager customerManager = new CustomerManager();
        customerManager.SendMessage();
        customerManager.ShowAlert();

        Console.WriteLine("-----------------");

        MyDelegate myDelegate = customerManager.SendMessage;
        myDelegate += customerManager.ShowAlert;
        myDelegate -= customerManager.SendMessage;
        myDelegate();

        Console.WriteLine("-----------------");

        MyDelegate2 myDelegate2 = customerManager.SendMessage2;
        myDelegate2 += customerManager.ShowAlert2;
        myDelegate2("Hello");

        Console.ReadLine();
    }

   

}
