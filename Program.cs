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
            recipeClass useRecipe = new recipeClass();
            IngrediantClass useobj2 = new IngrediantClass();

            useRecipe.name = "Cake";
            useRecipe.numSteps = 2;
 
            useRecipe.getSteps();
            useRecipe.printRecipe();


        }
    }




    class recipeClass {
        public String name { get; set; }
        public int numSteps { get; set; }

        


        public  string[] stepsArr = new string[29]; //Unknown Error with arrays over 30 elements big unique to my system
        

        
        public void getSteps()
        {
            int stepNum = 0; //adding this for less confusion for end user
            String stepsDesp;

            for (int i = 0; i < numSteps; i++) //for loop to gather all the array descriptions
            {
                stepNum++; //added for less confusion with step number 0 is 1 etc
                Console.WriteLine("Enter the description of step " + stepNum);
                
                stepsDesp = Console.ReadLine();

                while (stepsDesp.Equals("")==true){   //Checks if the step is empty and asks them to re-enter the step

                Console.WriteLine("Enter the description of step " + stepNum);
                    stepsDesp = Console.ReadLine();
                }

                stepsArr[i] = stepsDesp;
                
            }
        }


       

        /*public void menu() {
            int option;
        Console.WriteLine("(1) Enter a recipe\n(2) Clear a recipe\n(3) Scale the recipe\n(4) Return Recipe to orignal Scale\n(5) Exit");
        option = Convert.ToInt32(Console.ReadLine());



        switch(option)
            {
                case 1:

                break;

                case 2:

                break;

                case 3:

                break;

                case 4:

                break;

                case 5:

                break;
            }
        
        
        
        
        }*/ //For future use


        public void printRecipe() {
            int stepnum = 0;
            Console.WriteLine("_________________________________________________________________________________________________________\n" +
                "Recipen name :" + name);

            Console.WriteLine("----------------------------------------------Steps------------------------------------------------------");
            for (int i = 0; i < numSteps; i++) {
                stepnum++;
               
                Console.WriteLine("Step " + stepnum + ":" + stepsArr[i]);
            }

            Console.WriteLine("_________________________________________________________________________________________________________");
        }

        }



    class IngrediantClass {

        public int numOfIngred { get; set; }


        public String[] ingredName = new string[29];//Unknown Error with arrays over 30 elements big unique to my system
        public int[] ingredSize = new int[29];
        public String[] ingredType = new string[29];

    }
 }

