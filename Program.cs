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
            

            /*useRecipe.name = "Cake";
            useRecipe.numSteps = 2;

            useRecipe.getSteps();
            useRecipe.printRecipe();
            useobj2.numOfIngred = 3;
            useobj2.getIngredInfo();*/

      

          
        }
    }




    class recipeClass
    {
        public String name;


        IngrediantClass useIngredient = new IngrediantClass();
        StepsClass useSteps = new StepsClass();


        public void menu() {
            int option;
        Console.WriteLine("(1) Enter a recipe\n(2) Clear a recipe\n(3) Scale the recipe\n(4) Return Recipe to orignal Scale\n(5) Print Recipe\n(6)Exit");
        option = Convert.ToInt32(Console.ReadLine());

            while (option != 1 && option != 2 && option != 3 && option != 4 && option != 5 && option != 6) {
                Console.WriteLine("(1) Enter a recipe\n(2) Clear a recipe\n(3) Scale the recipe\n(4) Return Recipe to orignal Scale\n(5) Print Recipe\n(6)Exit");
                try { option = Convert.ToInt32(Console.ReadLine()); }
                catch { option = 0; }


            }

        switch(option)
            {
                case 1:
                    Console.WriteLine("Enter the name of the recipe");
                    name = Console.ReadLine();
                    while (name != null) {
                        Console.WriteLine("Enter the name of the recipe");
                        name = Console.ReadLine();
                    }
                break;

                case 2:

                break;

                case 3:

                break;

                case 4:

                break;

                case 5:

                break;

                case 6:
                    
                break;
            }
        
        
        
        
        } //For future use


        public void printRecipe()
        {

          
            Console.WriteLine("_________________________________________________________________________________________________________\n" +
                "Recipen name :" + name);

            Console.WriteLine("----------------------------------------------Steps------------------------------------------------------");
            

            Console.WriteLine("_________________________________________________________________________________________________________");
        }

    }

    class StepsClass {

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


        public void printSteps() {
            int stepnum = 0;




            for (int i = 0; i < numSteps; i++)
            {
                stepnum++;

                Console.WriteLine("Step " + stepnum + ":" + stepsArr[i]);
            }
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





                tempSize = 0;
                Console.WriteLine("Enter the amount of your ingredient " + tempName + ":");
                try
                {
                    tempSize = Convert.ToDouble(Console.ReadLine());
                }

                catch
                {
                    while (tempSize==0)
                    {
                        try
                        {
                            Console.WriteLine("Enter the amount of your ingredient " + tempName + ":");
                            tempSize = Convert.ToDouble(Console.ReadLine());
                        }
                        catch { 
                        tempSize =0;
                        }
                    }
                }
                    ingredSize[i] = tempSize;
                
               



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



        public void checkIfScale() {
            String temp;
            Console.WriteLine("Would you like to scale the recipe:\nYes\nNo");
            temp = Console.ReadLine();

            while (!temp.ToLower().Equals("yes") && !temp.ToLower().Equals("no"))
            {
                Console.WriteLine("Would you like to scale the recipe:\n(1) Yes\n(2) No");
                temp = Console.ReadLine();


            }

            if (temp.ToLower().Equals("yes"))
            {

                isScaled = true;
            }
            else
            {
                isScaled = false;
            }

        }

        public void scaleIngred() {
            
            double numberTemp;
            double scaleFactor = 0;
           

            if(isScaled==true)
            {
                

                //while checks if the scale factor has a correct option by only allowing 0.5, 2 and 3 to be inputted
                while (scaleFactor == 0 && scaleFactor!=0.5 && scaleFactor !=2 && scaleFactor !=3)
                {
                    try
                    {
                        Console.WriteLine("Would you like the the recipe scaled by a factor of : 0.5\t2\t3");
                        scaleFactor = Convert.ToDouble(Console.ReadLine());
                    }
                    catch
                    {
                        scaleFactor = 0;
                    }
                }


                for (int i = 0; i < numOfIngred; i++){


                    numberTemp = ingredSize[i];


                    numberTemp = numberTemp * scaleFactor;

                    Math.Round(numberTemp, 2);

                    ingredSizeScaled[i] = numberTemp;
                }



            }
        




        }



        public void printScale() {

            if (isScaled == true)
            {

                for (int i = 0; i < numOfIngred; i++)
                {

                    Console.WriteLine("Ingrediant : " + ingredName[i] + " amount : " + ingredSizeScaled[i] + " " + ingredType[i]);


                }


            }
            else {


                for (int i = 0; i < numOfIngred; i++)
                {

                    Console.WriteLine("Ingrediant : " + ingredName[i] + " amount : " + ingredSize[i] + " " + ingredType[i]);


                }



            }
        
        }
    }
}

