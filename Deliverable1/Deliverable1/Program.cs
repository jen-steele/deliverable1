using System;

namespace Deliverable1
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Which type of vacation do you prefer?\n\nmusical, tropical or adventurous: ");
            string vacationType = Console.ReadLine();


            Console.WriteLine("\nTotal number of people traveling: ");
            int groupSize;
            groupSize = int.Parse(Console.ReadLine());


            string travelMode = "";
            string destination = "";
            string result = "Since you're a group of " + groupSize + " going on a " + vacationType + " you should " + travelMode + " to " + destination ".";


            if (groupSize <= 2)
                travelMode = "travel first class";
            else if (groupSize > 2 && groupSize < 6)
                travelMode = "take a helicopter";
            else
                travelMode = "take a charter flight";


            switch (vacationType)
            {
                case "musical":
                    destination = "New Orleans";
                    break;
                case "tropical":
                    destination = "a beach vacation in Mexico";
                    break;
                case "adventurous":
                    destination = "go white water rafting in the Grand Canyon";
                    break; }


            {
                Console.WriteLine(result);

            }
                

            }

            
        }
    

    }

