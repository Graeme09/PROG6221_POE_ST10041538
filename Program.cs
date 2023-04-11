using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace POE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            methods useobj = new methods();
            String recipeName;
            int numOfSteps;
            int numOfIngredients;

            Console.WriteLine("Enter the name of the recipe");
            recipeName = Console.ReadLine();
            Console.WriteLine("Enter the amount of ingredients");
            numOfSteps = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the amount of Steps");
            numOfIngredients = Convert.ToInt32(Console.ReadLine());



            useobj.getSteps(4);
            useobj.getIngredients(4);

        }
    }




    class methods {
        public void getSteps(int numOfSteps)
        {
            String stepsDesp;

            for (int i = 0 + 1; i < numOfSteps + 1; i++)
            {

                Console.WriteLine("Enter the description of step " + i);
                stepsDesp = Console.ReadLine();
 

            }
        }

        int ingrediant;
        public void getIngredients(int numOfIngrediants) 
        {


            for (int i = 1;i <numOfIngrediants +1;i++) {
                Console.WriteLine("Enter the type of ingrediant" + i);
                ingrediant = Convert.ToInt32(Console.ReadLine());


            }
        
        }


        
        }
 }

