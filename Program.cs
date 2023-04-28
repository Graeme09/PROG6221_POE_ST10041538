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


            useRecipe.menu();

      

          
        }
    }




    class recipeClass
    {
        public String name;


        IngrediantClass useIngredient = new IngrediantClass();
        StepsClass useSteps = new StepsClass();


        public void menu() {
            int option = 0;
            int stepNum;
            int ingredientNum;
            String tempConfirm;
            Boolean recipeActive = false;


            while (option != 6)
            {
                Console.WriteLine("(1) Enter a recipe\n(2) Clear a recipe\n(3) Scale the recipe\n(4) Return Recipe to orignal Scale\n(5) Print Recipe\n(6)Exit");
                try { option = Convert.ToInt32(Console.ReadLine()); }
                catch { option = 0; }




                switch (option)
                {
                    case 1:

                        recipeActive = true;
                        Console.WriteLine("Enter the name of the recipe");
                        name = Console.ReadLine();
                        while (name.Equals(""))
                        {
                            Console.WriteLine("Enter the name of the recipe");
                            name = Console.ReadLine();
                        } //Entering recipe name and checking if it null


                        Console.WriteLine("Enter the number of steps between 1 and 29");
                        try { stepNum = Convert.ToInt32(Console.ReadLine()); }
                        catch { stepNum = 0; }

                        while (stepNum <0 || stepNum > 29)
                        {
                            Console.WriteLine("Enter the number of steps between 1 and 29");
                            try { stepNum = Convert.ToInt32(Console.ReadLine()); }
                            catch { stepNum = 0; }
                        }//Getting a number of steps between 1 and 29 due to an Error
                        useSteps.numSteps = stepNum;
                        useSteps.getSteps();


                        Console.WriteLine("Enter the number of Ingredient between 1 and 29");
                        try { ingredientNum = Convert.ToInt32(Console.ReadLine()); }
                        catch { ingredientNum = 0; }
                        while (ingredientNum <=0 || ingredientNum > 29)
                        {
                            Console.WriteLine("Enter the number of Ingredient between 1 and 29");
                            try { ingredientNum = Convert.ToInt32(Console.ReadLine()); }
                            catch { ingredientNum = 0; }
                        }//Getting a number of steps between 1 and 29 due to an Error
                        useIngredient.numOfIngred = ingredientNum;
                        useIngredient.getIngredInfo();
                        break;

                    case 2:
                        Console.WriteLine("Enter CONFIRM exactly as spelled to clear the array");
                        tempConfirm = Console.ReadLine();
                        if (tempConfirm.Equals("CONFIRM")) { //Checks if tempConfrim says CONFIRM
                            useIngredient.clearArray();
                            useSteps.clearArray();

                            recipeActive = false;//No active recipe

                        }
                        break;

                    case 3:
                        useIngredient.checkIfScale();
                        useIngredient.scaleIngred();
                        break;

                    case 4:
                        Console.WriteLine("The recipe has been converted to it's orignal values");
                        break;

                    case 5:
                        if (recipeActive == true) {


                        }
                        else{
                            Console.WriteLine("No Recipe Found");
                        }
                        break;

                    case 6:

                        break;
                }


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

        public void clearArray() {


            Array.Clear(stepsArr, 0, stepsArr.Length);
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
            //declaring temp vars

            for (int i = 0; i < numOfIngred; i++) //runs loop for amount of ingredients
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
                    while ( tempSize<=0) //gets size and confirms it's an actual number thats usable
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
                //adds to array
               



                Console.WriteLine("Enter the unit of measurement used for " + tempName + ":");
                tempType = Console.ReadLine();
                while (tempType.Equals("") == true)
                {   //Checks if the ingredient type is empty and asks them to re-enter the type

                    Console.WriteLine("Enter the unit of measurement used for " + tempName + ":");
                    tempName = Console.ReadLine();
                }

                ingredType[i] = tempType;
            }//adds to array



        }



        public void checkIfScale() {
            //Checks if 
            String temp;
            Console.WriteLine("Would you like to scale the recipe:\nYes\nNo");
            temp = Console.ReadLine();

            while (!temp.ToLower().Equals("yes") && !temp.ToLower().Equals("no"))
            {
                Console.WriteLine("Would you like to scale the recipe:\n(1) Yes\n(2) No");
                temp = Console.ReadLine();


            }
            //allows user to enter yes or no no matter of case
            if (temp.ToLower().Equals("yes"))
            {

                isScaled = true;
            }
            else
            {
                isScaled = false;
            }
            //sets boolean depending on answer
        }

        public void scaleIngred() {
            
            double numberTemp;
            double scaleFactor;


            if (isScaled == true)
            {

                Console.WriteLine("Would you like the the recipe scaled by a factor of : 0.5\t2\t3");
                try { scaleFactor = Convert.ToDouble(Console.ReadLine()); }
                catch { scaleFactor = 123; }
                //while checks if the scale factor has a correct option by only allowing 0.5, 2 and 3 to be inputted
                while (scaleFactor != 0.5 && scaleFactor != 2 && scaleFactor != 3)
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
                //Gets the scale factor and checks if its one of the options

                for (int i = 0; i < numOfIngred; i++)
                {


                    numberTemp = ingredSize[i];//retrieves old size


                    numberTemp = numberTemp * scaleFactor;//creates new size

                    Math.Round(numberTemp, 2);//rounds to 2 decimal places

                    ingredSizeScaled[i] = numberTemp;
                }
                


            }
            else {
                Console.WriteLine("The recipe will not be scaled");
            }
        




        }



        public void printScale() {

            if (isScaled == true)//checks if recipe has been scaled if so uses new scaled array
            {

                for (int i = 0; i < numOfIngred; i++)
                {

                    Console.WriteLine("Ingrediant : " + ingredName[i] + " amount : " + ingredSizeScaled[i] + " " + ingredType[i]);
                    //prints out all the ingrediants for the amount of ingrediants

                }


            }
            else {


                for (int i = 0; i < numOfIngred; i++)
                {
                    //prints out all the ingrediants for the amount of ingrediants
                    Console.WriteLine("Ingrediant : " + ingredName[i] + " amount : " + ingredSize[i] + " " + ingredType[i]);


                }



            }
        
        }


        public void clearArray()
        {

            Array.Clear(ingredName, 0 , ingredName.Length);
            Array.Clear(ingredSize, 0, ingredSize.Length);
            Array.Clear(ingredType, 0, ingredType.Length);
            Array.Clear(ingredSizeScaled, 0, ingredSizeScaled.Length);

        }
    }
}

