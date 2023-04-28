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

            /*useRecipe.name = "Cake";
            useRecipe.numSteps = 2;

            useRecipe.getSteps();
            useRecipe.printRecipe();*/
            useobj2.numOfIngred = 3;
            useobj2.getIngredInfo();

          
        }
    }




    class recipeClass
    {
        public String name { get; set; }
        public int numSteps { get; set; }




        public string[] stepsArr = new string[29]; //Unknown Error with arrays over 30 elements big unique to my system



        public void getSteps()
        {
            int stepNum = 0; //adding this for less confusion for end user
            String stepsDesp;

            for (int i = 0; i < numSteps; i++) //for loop to gather all the array descriptions
            {
                stepNum++; //added for less confusion with step number 0 is 1 etc
                Console.WriteLine("Enter the description of step " + stepNum);

                stepsDesp = Console.ReadLine();

                while (stepsDesp.Equals("") == true)
                {   //Checks if the step is empty and asks them to re-enter the step

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


        public void printRecipe()
        {
            int stepnum = 0;
            Console.WriteLine("_________________________________________________________________________________________________________\n" +
                "Recipen name :" + name);

            Console.WriteLine("----------------------------------------------Steps------------------------------------------------------");
            for (int i = 0; i < numSteps; i++)
            {
                stepnum++;

                Console.WriteLine("Step " + stepnum + ":" + stepsArr[i]);
            }

            Console.WriteLine("_________________________________________________________________________________________________________");
        }

    }



    class IngrediantClass
    {

        public int numOfIngred { get; set; }


        public String[] ingredName = new string[29];//Unknown Error with arrays over 30 elements big unique to my system
        public double[] ingredSize = new double[29];
        public String[] ingredType = new string[29];

        Boolean isScaled;                               //Boolean and array used if the recipe is scaled
        public double[] ingredSizeScaled = new double[29];

        public void getIngredInfo()
        {
            int ingredCount = 0; 
            String tempName;
            double tempSize;
            String tempType;


            for (int i = 0; i < numOfIngred; i++)
            {
                ingredCount++;
                Console.WriteLine("Enter the name of your ingredient " + ingredCount + ":");
                tempName = Console.ReadLine();


                while (tempName.Equals("") == true)
                {   //Checks if the ingredient name is empty and asks them to re-enter the name

                    Console.WriteLine("Enter the name of your ingredient " + ingredCount + ":");
                    tempName = Console.ReadLine();
                }
                ingredName[i] = tempName;






                Console.WriteLine("Enter the amount of your ingredient " + tempName + ":");
                try
                {
                    tempSize = Convert.ToDouble(Console.ReadLine());
                    ingredSize[i] = tempSize;
                }
                catch
                {
                    while (ingredSize[i] == null)
                    {
                        Console.WriteLine("Enter the amount of your ingredient " + tempName + ":");
                        tempSize = Convert.ToDouble(Console.ReadLine());
                        try
                        {
                            ingredSize[i] = tempSize;

                        }
                        catch
                        {
                            Console.WriteLine("Please only enter a number value");
                        }
                    }
                }



                Console.WriteLine("Enter the unit of measurement used for " + tempName + ":");
                tempType = Console.ReadLine();
                while (tempType.Equals("") == true)
                {   //Checks if the ingredient name is empty and asks them to re-enter the name

                    Console.WriteLine("Enter the unit of measurement used for " + tempName + ":");
                    tempName = Console.ReadLine();
                }

                ingredType[i] = tempType;
            }



        }

        public void scaleIngred() {
            int temp;
            Console.WriteLine("Would you like to scale the recipe:\n(1) Yes\n(2) Yes");
            temp = Convert.ToInt32(Console.ReadLine());
        
        
        }
    }
}

