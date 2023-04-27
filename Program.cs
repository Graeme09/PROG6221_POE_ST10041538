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
            MeasurementClass useobj2 = new MeasurementClass();

            useRecipe.name = "Cake";
            useRecipe.numSteps = 2;
            useRecipe.getSteps();
            useRecipe.printRecipe();


        }
    }




    class recipeClass {
        public String name { get; set; }
        public int numSteps { get; set; }


        public  string[] stepsArr = new string[29];
        int[] ingredients;
        String[] ingredientsMeasurement; 

        
        public void getSteps()
        {
            int stepNum = 0;
            String stepsDesp;

            for (int i = 0; i < numSteps; i++)
            {
                stepNum++;
                Console.WriteLine("Enter the description of step " + stepNum);
                stepsDesp = Console.ReadLine();

      

                stepsArr[i] = stepsDesp;
                
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



    class MeasurementClass { 
    
        public String getMeasurementUnit()
        {
            String unit = null;
            int option = 0;

            Console.WriteLine("What type of unit of measurement are you using:\n" +
                "(1) ml\n(2) grams\n");

            while (option != 1 && option != 2 && option!=3)
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

            switch (option) {
                case 1:
                    unit = "ml";
                break;

                case 2:
                    unit = "grams";
                break;

            }

            return unit;
        }


        public int convertMeasurementUnit(int amount, String type) {
            int converstion = 0;


            if (type.Equals("Cups"))
            {
                converstion = amount * 250;

            }
            else {
                if (type.Equals("Tablespoons"))
                {
                    converstion = amount * 15;
                }
                else
                {
                    if (type.Equals("Teaspoons"))
                    {

                        converstion = amount * 5;
                    }

                }
            
            }



            return converstion;
        }
    }
 }

