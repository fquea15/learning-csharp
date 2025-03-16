using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // hola Mundo
            Console.WriteLine("Hello World!");
            /*
            Esto
            es
            un
            comentario
            */

            // Type data string
            string lastName = "Esto es una cadena de texto";
            lastName = "Aqui cambia el valor de lastName";
            Console.WriteLine(lastName);

            // Type data numeric
            int myInt = 7;
            myInt = myInt + 4;
            Console.WriteLine(myInt);
            Console.WriteLine(myInt - 1);

            // type data double
            double myDouble = 6.5;
            Console.WriteLine(myDouble);

            // type data float
            float myFloat = 6.5f;
            Console.WriteLine(myFloat);

            // sum of numeric data
            Console.WriteLine(myDouble + myFloat + myInt);

            // Type data boolean
            bool myBool = true;
            myBool = false;
            Console.WriteLine(myBool);

            // type data decimal
            dynamic myDynamic = 6.5;
            myDynamic = "Aqui cambia el valor de myDynamic";
            Console.WriteLine(myDynamic + myFloat);

            // var data type
            var myVar = "Mi variable de tipo inferido";
            // myVar = 6.5; Error
            Console.WriteLine(myVar);

            // concatenation of strings
            Console.WriteLine($"El valor de mi entero es {myInt} y el de mi bool es {myBool}");

            // type data const
            const string MyConst = "mi constante";
            Console.WriteLine(MyConst);

            // struct
            // array
            var myArray = new string[] { "FCode", "Quea", "Freddy" };
            Console.WriteLine(myArray[0]);
            myArray[2] = "22";
            Console.WriteLine(myArray[2]);

            // dictionary
            var myDictionary = new Dictionary<string, int>{
                { "FCode", 1 },
                { "Quea", 2 },
                { "Freddy", 3 }
            };
            Console.WriteLine(myDictionary["FCode"]);

            // set
            var mySet = new HashSet<string> { "FCode", "Quea", "Freddy", "Freddy" };
            Console.WriteLine(mySet.Contains("FCode"));

            // tuple
            var myTuple = (1, "FCode", true);
            Console.WriteLine(myTuple.Item1);

            // bucles
            // for 
            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine(index);
            }

            // foreach
            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }
            foreach (var item in myDictionary)
            {
                Console.WriteLine(item);
            }

            foreach (var item in mySet)
            {
                Console.WriteLine(item);
            }

            // flujos
            myInt = 12;
            if (myInt == 11 && myBool == true)
            {
                Console.WriteLine($"myInt es {myInt}");
            }
            else if (myInt == 12 || myBool == false)
            {
                Console.WriteLine($"myInt es {myInt}");
            }
            else
            {
                Console.WriteLine("myInt no es 11 ni 12");
            }

            // Functions
            MyFunction();
            Console.WriteLine(MyFunctionWithReturn(5));

            // class
            var myClass = new MyClass("Freddy");
            myClass.myName = "Freddy2";
            Console.WriteLine(myClass.myName);

        }
        // Functions
        static void MyFunction()
        {
            Console.WriteLine("Hola desde una funcion");
        }

        static int MyFunctionWithReturn(int param)
        {
            return param + 10;
        }

        // class
        class MyClass
        {
            public string myName { get; set; }

            public MyClass(string myName)
            {
                this.myName = myName;
            }
        }
    }
};



