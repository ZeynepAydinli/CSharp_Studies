// Generics

public class Program
{
    private static void Main(string[] args)
    {

        // ------------------- List -------------------

        List<string> cities = new List<string>();
        cities.Add("Bursa");

        MyList<string> cities2 = new MyList<string>();
        cities2.Add("Datça");


        // ------------------- Metot -------------------

        Utilities utilities = new Utilities();
        List<string> result = utilities.BuidList<string>("Ankara", "İzmir", "Bursa");

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }

        List<Customer> customers = utilities.BuidList<Customer>(
            new Customer { Name = "Zeynep"}, new Customer { Name = "Pelte"});

        foreach (var customer in customers)
        {
            Console.WriteLine(customer.Name);
        }
        
        Console.ReadLine();

    }
}

// ------------------- List -------------------

class MyList<T> 
{
    public void Add(T item)
    {

    }
}

// ------------------- İnterface, Class -------------------

class Customer : IEntity
{
    public string Name { get; set; }
}

interface IEntity
{

}

interface IRepository<T> where T : class, IEntity, new() // Sadece IEntity implemansyonu olabilir.
{                                                        // Değer tip için sadece where T : struct yazılır
    List<T> GetAll();
    T Get(int id);
    void Add(T item);
    void Update(T item);
    void Delete(int id);
}

interface ICustomer : IRepository<Customer>
{
    // Buraya ICustomer için özel kodlar yazılabilir
}

class CustomerDal : ICustomer
{
    public void Add(Customer item)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Customer Get(int id)
    {
        throw new NotImplementedException();
    }

    public List<Customer> GetAll()
    {
        throw new NotImplementedException();
    }

    public void Update(Customer item)
    {
        throw new NotImplementedException();
    }
}

// ------------------- Metot -------------------

class Utilities
{
    public List<T> BuidList<T> (params T[] items)
    {
        return new List<T>(items);
    }
}