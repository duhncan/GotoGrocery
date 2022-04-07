#define MEMBERTESTING


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GoToGrocery
{

    class Program
    {
        

        static void Main(string[] args)
        {
            #if MEMBERTESTING
            Console.WriteLine("Duhncan's Code");
            Members testMember = new Members("Duhncan", "Guy", "102093756@student.swin.edu.au", "12/05/1999");

            Console.WriteLine("Member Class Creation and Constructor Test");
            Console.WriteLine(
                "\n First Name:\t" + testMember.FName +
                "\n Last Name:\t" + testMember.LName +
                "\n Full Name:\t" + testMember.FullName() +
                "\n Email:\t\t" + testMember.Email +
                "\n DoB:\t\t" + testMember.Dob
                );

            #endif

            Console.WriteLine("\nThe application has run successfully!");
            Console.WriteLine("Type Enter to Exit Program...");
            Console.ReadLine();





        }
    }
}
