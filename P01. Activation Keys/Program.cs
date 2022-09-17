using System;
using System.Linq;

namespace P01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string initional = Console.ReadLine();
            string input = Console.ReadLine();
            while (input!= "Reveal")
            {
                string[] inputArr = input.Split(":|:");
                string command = inputArr[0];
                if (command == "InsertSpace")
                {
                    int index = int.Parse(inputArr[1]);
                    if (index>= 0 && index < initional.Length)
                    {
                        initional = initional.Insert(index, " ");
                    }
                    Console.WriteLine(initional);
                }
                if (command == "Reverse")
                {
                    string substring = inputArr[1];
                    if (initional.Contains(substring))
                    {
                        int indexSub = initional.IndexOf(substring);
                        initional = initional.Remove(indexSub, substring.Length);
                        string newSub = string.Empty;
                        for (int i = substring.Length - 1; i >= 0; i--)
                        {
                            newSub += substring[i];
                        }
                        initional = initional + newSub;
                        Console.WriteLine(initional);
                    }
                    else
                    {
                        Console.WriteLine($"error");
                    }
                   
                }
                if (command == "ChangeAll")
                {
                    string substring = inputArr[1];
                    string replacement = inputArr[2];
                    if ((initional.Contains(substring)))
                    {
                        initional = initional.Replace(substring, replacement);

                    } 
                    
                        
                    
                    Console.WriteLine(initional);

                }


                input = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {initional}");
        }
    }
}
