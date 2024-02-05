using System;
using System.Collections.Generic;

namespace ListExercises
{
    internal class Program
    {
        public static void Main()
        {
        }
        //*If no one likes your post, it doesn't display anything.
        //*If only one person likes your post, it displays: [Friend's Name] likes your post.
        //*If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
        //*If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
        
        //Write a program and continuously ask the user to enter different names, until the user presses Enter
        //(without supplying a name). Depending on the number of names provided, display a message based on the above pattern.


        public static void Exercise1()
        {
            Console.WriteLine("Enter the friends who have liked your post one at a time");
            Console.WriteLine("Once complete press enter: ");

            var names = new List<string>();

            while (true)
            {
                Console.Write("Enter name: ");
                var name = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(name))
                {
                    break;
                }
                names.Add(name);
            }

            if (names.Count == 1)
                Console.WriteLine($"{names[0]} liked your post");
            else if (names.Count == 2)
                Console.WriteLine($"{names[0]} and {names[1]} liked your post");
            else if (names.Count > 2)
                Console.WriteLine($"{names[0]} and {names[1]} and {names.Count - 2} others liked your post");
            
        }
        
        
        //Write a program and ask the user to enter their name. Use an array to reverse the name and then store the
        //result in a new string. Display the reversed name on the console.

        public static void Exercise2()
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            
            var reversed = new char[name.Length];

            var x = 0;
            for (var i = name.Length - 1; i >= 0; i--)
            {
                reversed[x]= name[i];
                x++;
            }

            var reversedName = new String(reversed);

            Console.WriteLine(reversedName);

        }
        
        //Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display 
        //an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them 
        //and display the result on the console.

        public static void Exercise3()
        {
            Console.WriteLine("Enter 5 unique numbers 1 at a time");
            var numbers = new List<int>();
            
            for (var i = 1; i <= 5; i++)
            {
                Console.Write("Enter number: ");
                var input = Console.ReadLine();
                var number = Convert.ToInt32(input);
                if (numbers.Contains(number))
                {
                    Console.WriteLine("Error, this number was already entered, try again.");
                    continue;
                }
                numbers.Add(number);
            }


            numbers.Sort();
            foreach (var l in numbers)
            {
                Console.WriteLine(l);
            }
        }
        
        // Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may 
        // include duplicates. Display the unique numbers that the user has entered.

        public static void Exercise4()
        {
            Console.WriteLine("Enter as many numbers as you like one at a time. When you're done enter 'quit'");
            var numbers = new List<int>();
            
            while(true)
            {
                Console.Write("Enter Number: ");
                var input = Console.ReadLine();
                if (input == "quit" || input == "Quit")
                {
                    break;
                }
                numbers.Add(Convert.ToInt32(input));
            }

            var uniqueNums = new List<int>();

            foreach (var num in numbers)
            {
                if (!uniqueNums.Contains(num))
                {
                    uniqueNums.Add(num);
                }
            }

            foreach (var n in uniqueNums)
            {
                Console.WriteLine(n);
            }
        }
        
        // Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is 
        // empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display 
        // the 3 smallest numbers in the list.

        public static void Exercise5()
        {
            while(true)
            {
                Console.WriteLine("Enter a list, of at least, 5 comma seperated numbers.");
                var input =  Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Invalid List");
                    continue;
                }
                var array = input.Split(',');
                if(array.Length <5)
                {
                    Console.WriteLine("Invalid List");
                    continue;
                }
                
                var list = new List<int>();
                
                for (var n = 0; n<=array.Length -1; n++)
                {
                    list.Add(Convert.ToInt32(array[n]));    
                }
                
                var threeSmallest = new List<int>();
                for(var i = 0; i<=2; i++)
                {
                    var smallest = list[0];
                    foreach (var element in list)
                    {
                        if (element < smallest)
                        {
                            smallest = element;
                        }
                    }
                    threeSmallest.Add(smallest);
                    list.Remove(smallest);
                }

                Console.WriteLine("The three smallest numbers you entered are: ");
                foreach (var smallNum in threeSmallest)
                {
                    Console.WriteLine(smallNum);
                }
                break;
            }
        }
    }
}