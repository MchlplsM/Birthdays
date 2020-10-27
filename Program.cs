using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthdays_Loop
{
    class Program
    {
//------------------------------------------------------MAIN-----------------------------------------------------------        
         static void Main(string[] args)
        {
            int noOfFriends = 2;
            string[] firstNames = new string[noOfFriends];
            string[] lastNames = new string[noOfFriends];
            string[] telephones = new string[noOfFriends];
            string[] datesOfBirth = new string[noOfFriends];
            
            MethodForFor(firstNames, lastNames, telephones, datesOfBirth);
        }
//-------------------------------------------------METHOD---------------------------------------------------------------
        static void MethodForFor(string[] firstNames, string[] lastNames, string[] telephones, string[] datesOfBirth)
        {
            for(int i = 0; i < firstNames.Length; i++)
            {
                DataForPerson(i);
                firstNames[i] = ProvideYourDetail("\nPlease provide your First Name: "); //WE CALL THE METHOD ProvideYourDetail
                
                lastNames[i] = ProvideYourDetail("\nPlease provide your Last Name: ");
                
                telephones[i] = ProvideYourDetail("\nPlease provide your Telephone: ");
                
                datesOfBirth[i] = ProvideYourDetail("\nPlease provide your Date of birth: ");

                Console.WriteLine($"\n{firstNames[i]} {lastNames[i]}, {telephones[i]}, {datesOfBirth[i]}\n");
            }
        }
        static string ProvideYourDetail(string message)
        {   //block of code == body of the method
            string x;
            Console.WriteLine(message);
            x = Console.ReadLine();
            return x;
        }
        static void DataForPerson(int i)
        {
            Console.WriteLine($"Please provide data for friend No{i + 1}\n");
        }
    }
}
