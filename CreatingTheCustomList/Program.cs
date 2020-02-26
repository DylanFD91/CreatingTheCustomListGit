using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingTheCustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(2);
            numbers.Add(4);
            numbers.Add(6);
            numbers.Add(8);
            numbers.Add(10);


            /*(10 points): As a developer, I want to be able to overload the + operator, so that I can add two instances of the custom list class together.
            - List<int> one = new List<int>() {1,3,5}; and List<int> two = new List<int>() {2,4,6};
            - List<int> result = one + two;
            - result has 1,3,5,2,4,6

            (10 points): As a developer, I want to be able to overload the – operator, so that I can subtract 
            one instance of a custom list class from another instance of a custom list class.
            - List<int> one = new List<int>() {1,3,5}; and List<int> two = new List<int>() {2,1,6};
            - List<int> result = one - two;
            - result has 3,5

            (5 points): As a developer, I want to write documentation in a .txt file that describes the details 
            and functionality of my – operator overload. I want to include details such as “syntax”, “parameters”, “return type”, 
            and an example of it being used, with the output. I want to use the following piece of documentation as a guideline 
            for my own documentation:
            https://msdn.microsoft.com/en-us/library/cd666k3e%28v=vs.110%29.aspx?f=255&MSPPError=-2147217396

            (10 points): As a developer, I want the ability to zip two custom list class instances together in the form of a zipper. An example:
            - I have List<int> odd = new List<int>() {1,3,5}; and List<int> even = new List<int>() {2,4,6};
            - odd.Zip(even);
            - When lists odd and even are zipped together, your new list will contain values 1,2,3,4,5,6

            (10 points): As a developer, I want the custom list class to be iterable.

            (10 points): As a developer, I want to use C# best practices, SOLID design principles, and good naming conventions on the project.

            (Bonus 5 points): As a developer, I want the ability to sort an instance of my custom-built list class. 
            To be eligible for the bonus points, you may not use Array.Sort() that is already built in and you must tell 
            us what sorting algorithm you used.

            (Bonus 5 points): As a developer, I want the ability to earn bonus points for an EASTER EGG user story, 
            regarding implementing a specific good practice on one of the methods specified in a user story above. */

        }
    }
}
