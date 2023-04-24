using System;
using System.Collections;
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
            MethodException useobj2 = new MethodException();
            useobj2.getMeasurementUnit();

        }
    }




    class methods {
        String name;
        int numSteps;

        ArrayList steps = new ArrayList();
        ArrayList ingredients = new ArrayList();
        ArrayList ingredientsType = new ArrayList();

        public void getNumSteps() {
            int temp;

            Console.WriteLine("Enter the num of steps");
            temp = Convert.ToInt32(Console.ReadLine());
        
            numSteps = temp;
        }
        
        public void getSteps(int numOfSteps)
        {
            String stepsDesp;

            for (int i = 0 + 1; i < numOfSteps + 1; i++)
            {

                Console.WriteLine("Enter the description of step " + i);
                stepsDesp = Console.ReadLine();



                steps.Add("Step " + i + " " +stepsDesp);
                
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

       

        public void menu() {
            int option;
        Console.WriteLine("(1) Enter a recipe\n(2) Clear a recipe\n(3) Scale the recipe\n(4) Exit\n ");
        option = Convert.ToInt32(Console.ReadLine());



        switch(option)
            {
                case 1:

                break;

                case 2:

                break;

                case 3:

                break;
            }
        
        
        
        
        }


        }



    class MethodException { 
    
        public String getMeasurementUnit()
        {
            String unit = null;
            int option = 0;

            Console.WriteLine("What type of unit of measurement are you using:\n" +
                "(1)ml\n(2)grams");

            while (option != 1 && option != 2)
            {
                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("------------Please only enter 1 or 2------------");

                }
            }




            return unit;
        }
    }
 }

