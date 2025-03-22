using System.Text.Json;

namespace SharpBack;

class Program
{
  // Funcion Principal
  static void Main(string[] args)
  {
    // LINQ
    var names = new List<string>()
    {
      "Hector", "Francisco", "Ana", "Hugo", "Pedro"
    };

    var namesResult = from n in names
      where n.Length > 3 && n.Length < 5
      orderby n descending
      select n;

    var namesResult2 = names.Where(n => n.Length > 3 && n.Length < 5)
      .OrderByDescending(n => n)
      .Select(n => n);
    

    foreach (var name in namesResult2)
    {
      Console.WriteLine(name);
    }

    // // Lambda Expressions - FUNCIONES FLECHA - TS
    Func<int, int, int> sub = (a, b) => a - b;

    Func<int, int> some = a => a * 2;
    Func<int, int> some2 = a =>
    {
      a++;
      return a * 2;
    };
    Some((a, b) => a + b, 12);

    sub(1, 4);
    Console.WriteLine(some2(2));

    void Some(Func<int, int, int> fn, int number)
    {
      var result = fn(number, number);
      Console.WriteLine(result);
    }

    // // Funcion de Primera Clase ----->
    // var show = ShowHelp;
    // show("Hello World!");
    //
    // Some(show, "Hola como Estas....");
    //
    // string ShowHelp(string mesage)
    // {
    //   return mesage.ToUpper();
    // }
    //
    // // CallBack Con Retorno
    // void Some(Func<string,string> fn, string mesage)
    // {
    //   Console.WriteLine("Hace algo al Inicio!");
    //   Console.WriteLine(fn(mesage));
    //   Console.WriteLine("Hace algo al Final!");
    // }

    // CallBack Sin retorno
    // void Some(Action<string> fn, string mesage)
    // {
    //   Console.WriteLine("Hace algo al Inicio!");
    //   fn(mesage);
    //   Console.WriteLine("Hace algo al Fina;!");
    // }

    // // Programación Funcional ------>
    // // -----Funcion Pura---->
    // int Sum(int a, int b)
    // {
    //   return a + b;
    // }
    //
    // DateTime GetTomorrow(DateTime date)
    // {
    //   return date.AddDays(1);
    // }
    //
    // var date = DateTime.Now;
    // Console.WriteLine(GetTomorrow(date));
    //
    // var beer = new Beer()
    // {
    //   Name = "guinness",
    //   Price = 9.99m,
    // };
    //
    // Beer ToUpper(Beer beer)
    // {
    //   var beer2 = new Beer()
    //   {
    //     Name = beer.Name.ToUpper(),
    //     Price = beer.Price,
    //   };
    //   return beer2;
    // }
    //
    // Console.WriteLine(ToUpper(beer));
    // Console.WriteLine(beer.Name);

    // // Serialización y deserialización --------->
    // var hector = new People()
    // {
    //   Name = "Hector",
    //   Age = 18,
    // };
    //
    // string json = JsonSerializer.Serialize(hector);
    // Console.WriteLine(json);
    //
    // string myJson = @"
    // {
    //   ""Name"":""Juan"",
    //   ""Age"":18
    // }";
    //
    // var juan = JsonSerializer.Deserialize<People>(myJson);
    // Console.WriteLine(juan?.Name);
    // Console.WriteLine(juan?.Age);
    //
    // // Metodos estaticos de una clase
    // Console.WriteLine(People.Get());

    // // Generics ------------>
    // var numbers = new MyList<int>(5);
    // var names = new MyList<string>(5);
    // var beers = new MyList<Beer>(3);
    //
    // numbers.Add(1);
    // numbers.Add(2);
    // numbers.Add(3);
    // numbers.Add(4);
    // numbers.Add(5);
    // numbers.Add(6);
    // numbers.Add(7);
    // numbers.Add(8);
    //
    // names.Add("John");
    // names.Add("Jane");
    // names.Add("Mary");
    // names.Add("Jeremy");
    // names.Add("Jack");
    // names.Add("Jim");
    // names.Add("Jon");
    //
    // beers.Add(new Beer()
    // {
    //   Name = "Erdinger",
    //   Price = 5
    // });
    // beers.Add(new Beer()
    // {
    //   Name = "Corona",
    //   Price = 1
    // });
    // beers.Add(new Beer()
    // {
    //   Name = "Delirium",
    //   Price = 10
    // });
    // beers.Add(new Beer()
    // {
    //   Name = "Paulaner",
    //   Price = 5
    // });
    //
    // Console.WriteLine(numbers.GetContent());
    // Console.WriteLine(names.GetContent());
    // Console.WriteLine(beers.GetContent());

    // // Interfaces ------>
    // var sale = new Sale(20);
    // var beer = new Beer();
    //
    // Some(sale);
    // Some(beer);
    //
    // void Some(ISave save)
    // {
    //   save.Save();
    // }

    // // Herencia---------->
    // var sale = new SaleWithtax(18, 1.16m);
    // var message = sale.GetInfo();
    //
    // Console.WriteLine(message);

    // --- Clase Sale --->
    // Sale sale = new();
    // Sale sale = new Sale();
    // var sale = new Sale(15);
    // var message = sale.GetInfo();
    // Console.WriteLine(message);
  }
}

// Serialización y deserialización
public class People
{
  public string Name { get; set; }
  public int Age { get; set; }

  // Metodos estaticos de una clase
  public static string Get() => "Hola mundo";
}

// Generics
public class MyList<T>
{
  private List<T> _list;
  private int _limit;

  public MyList(int limit)
  {
    _limit = limit;
    _list = new List<T>();
  }

  public void Add(T item)
  {
    if (_list.Count < _limit)
    {
      _list.Add(item);
    }
  }

  public virtual string GetContent()
  {
    string content = "";
    foreach (var item in _list)
    {
      content += item + ", ";
    }

    return content;
  }
}

// Interfaces --->
interface IIsale
{
  decimal Total { get; set; }
}

interface ISave
{
  public void Save();
}

// Clase Hija
class SaleWithtax : Sale
{
  public decimal Tax { get; set; }

  // Constructor
  public SaleWithtax(decimal total, decimal tax) : base(total)
  {
    Tax = tax;
  }

  // Sobreescritura
  public override string GetInfo()
  {
    return $"El Total es: {Total}, y el Impuesto es: {Tax}";
  }

  // Sobre Carga
  public string GetInfo(string message)
  {
    return message;
  }

  // Sobre Carga
  public string GetInfo(string message, decimal tax)
  {
    return message + $" El Total es: {tax}";
  }
}

// Clase Padre
public class Sale : IIsale, ISave
{
  // Atributos
  public decimal Total { get; set; }
  private decimal _some;

  // Constructor
  public Sale(decimal total)
  {
    Total = total;
    _some = 8;
  }

  public void Save()
  {
    Console.WriteLine("Sale Save");
  }

  // Perimite la Sobreescritura
  public virtual string GetInfo()
  {
    return $"El Total es: {Total + _some}";
  }
}

public class Beer : ISave
{
  public string Name { get; set; }
  public decimal Price { get; set; }

  public override string ToString()
  {
    return $"{Name} - {Price}";
  }

  public void Save()
  {
    Console.WriteLine("Beer Save en DB");
  }
}