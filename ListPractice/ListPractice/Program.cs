using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace ListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> dogs = new List<string>() { "Golden", "Dolberman", "Pug" };
            Console.WriteLine("The number of dogs in the first list is {0}", dogs.Count);

            dogs.Add("mutt");
            Console.WriteLine("The number of dogs in the second list is {0}", dogs.Count);

            dogs.Clear();
            Console.WriteLine("There are now {0} dogs left", dogs.Count);
        }
    }
}

*/

/*namespace ListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3];
            array[0] = 2;
            array[1] = 3;
            array[2] = 5;

            List<int> list = new List<int>(array);
            Console.WriteLine("The original list has {0} numbers", list.Count);
            Console.WriteLine("The original list has the following numbers:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine("Please give me another integer to add to the list: ");
            int number = int.Parse(Console.ReadLine());
            list.Add(number);

            Console.WriteLine("The new list contains the following numbers: ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine("The number of items in the list is {0}", list.Count);
        }
    }
}
*/

/*namespace ListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //moving list into an array

            int[] array = new int[3];
            array[0] = 2;
            array[1] = 3;
            array[2] = 5;

            List<int> listOfNumbers = new List<int>(array);
            Console.WriteLine(listOfNumbers.Count);

            int[] convertedArray = listOfNumbers.ToArray();

            Console.WriteLine(convertedArray.Length);
        }
    }
}
*/

/*namespace ListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //removing item from a list

            int[] array = new int[3];
            array[0] = 2;
            array[1] = 3;
            array[2] = 5;

            List<int> listOfNumbers = new List<int>(array);
            Console.WriteLine("The number of items on the list is {0}", listOfNumbers.Count);
            listOfNumbers.Remove(2); //deletes the number 2 in the list, NOT the second element in the list

            Console.WriteLine("I removed the number 2 from the list. Now the list has {0} numbers in the list. The updated list is now...", listOfNumbers.Count);

            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                Console.WriteLine(listOfNumbers[i]);
            }

        }
    }
}
*/

/*
    class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();

        foreach( int currentValue in list)
        {
            Console.WriteLine(currentValue);
        }
    }
}
*/

/*class Program
{
    static void Main(string[] args)
    {
        List<string> farm = new List<string>() { "pig", "sheep", "cow", "chicken", "horse" };

        Console.WriteLine("The first list: ");
        foreach (string animal in farm)
        {
            Console.WriteLine(animal);
        }

        farm.Add("goat");

        Console.WriteLine("The new list with added animal:");
        foreach(string animal in farm)
        {
            Console.WriteLine(animal);
        }
            
        }
    }
    */
/*class Program
{
    static void Main(string[] args)
    {
        List<bool> boolList = new List<bool>() { true, false, false, true, false };


        foreach (bool x in boolList )
        {
            if (x == true) {
                Console.WriteLine("Better bring an umbrella!");
            }

            else
            {
                Console.WriteLine("No rain today; enjoy the sun!");
            }
        }
   
    }
}
*/

/*class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[] { 5, 2, 3, 4, 1, 5, 6, 3 };

        List<int> listOfNumbers = new List<int>(array);

        listOfNumbers.Sort();

        Console.WriteLine("list after sorting: ");
        foreach (int number in listOfNumbers)
        {
            Console.WriteLine(number);
        }
            

        int[] convertedArray = listOfNumbers.ToArray();

        array = convertedArray;

        Console.WriteLine("array list:");

        foreach(int number in array)
        {
            Console.WriteLine(number);
        }

        

    }
}
*/


/*class Program
{
    static void Main(string[] args)
    {
        List<int> listOfNumbers = new List<int>() { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };

        Console.WriteLine("Here's the original list: ");
        foreach (int number in listOfNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("Is 77 in the list?");

        listOfNumbers.Contains(23);
        Console.WriteLine(listOfNumbers.Contains(77));
        listOfNumbers.Contains(15);

        listOfNumbers.Remove(27);
        listOfNumbers.Remove(77);
        listOfNumbers.Remove(32);
        listOfNumbers.Remove(6);

        Console.WriteLine("Here is the list after the .Remove()");
        foreach(int number in listOfNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("Is 77 still here?");

        listOfNumbers.Contains(23);
        Console.WriteLine(listOfNumbers.Contains(77));
        listOfNumbers.Contains(15);

    }


}
*/