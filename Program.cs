using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
                ArrayList studentGrades;
                studentGrades = new ArrayList() { 85, 92, 78, 95, 88 };

                Console.WriteLine("Displaying student grades:");
                foreach (var grade in studentGrades)
                {
                    Console.WriteLine(grade);
                }   
                
                Console.WriteLine("\nCalculating and displaying the sum of grades:");
                int sum = 0;
                foreach (var grade in studentGrades)
                {
                    sum += (int)grade;
                }
                Console.WriteLine("Sum of grades: " + sum);

               // Add a new grade of 90 to the end of studentGrades.
               studentGrades.Add(90);

                Console.WriteLine("\nDisplaying student grades after adding a new grade:");
                foreach (var grade in studentGrades)
                {
                    Console.WriteLine(grade);
                }
              
                // Remove the grade of 78 from studentGrades.
                studentGrades.Remove(78);
             
                Console.WriteLine("\nDisplaying student grades after removing a grade:");
                foreach (var grade in studentGrades)
                {
                    Console.WriteLine(grade);
                }

                //Search for the index of the grade 95 in studentGrades.
                int indexOf95 = studentGrades.IndexOf(95);

                //Update the grade at the found index to 96.
                if (indexOf95 != -1)
                {
                    studentGrades[indexOf95] = 96;
                }

                Console.WriteLine("\nDisplaying student grades after updating a grade:");
                foreach (var grade in studentGrades)
                {
                    Console.WriteLine(grade);
                }
                Console.ReadKey();
            }
        }

    }
