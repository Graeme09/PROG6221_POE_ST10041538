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
            String recipeName;
            int numOfSteps;
            int numOfIngredients;


            Console.WriteLine("Enter the name of the recipe");
            recipeName = Console.ReadLine();


            numOfIngredients  = useobj2.numQuestion("Enter the amount of ingrediants there are: ");
            numOfSteps = useobj2.numQuestion("Enter the amount of steps there are:");



            useobj.getIngredients(numOfIngredients);
            useobj.getSteps(numOfSteps);

            
            SortedList<int, String> ingredients = new SortedList<int,String>();
        }
    }




    class methods {
        String name;
        ArrayList steps = new ArrayList();
        ArrayList ingredients = new ArrayList();
        ArrayList ingredientsType = new ArrayList();
        
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

        public void makeRecipe() { 
        
        
        
        }

        public void menu() {
            int option;
        Console.WriteLine("(1) Enter a recipe\n(2) Scale a recipe\n(3) Exit ");
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
    
    public int numQuestion(String question)
        {
            int num;
            Console.WriteLine(question);
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                num = 0;

            }
            while (num == 0)
            {

                Console.WriteLine("--------------------ERROR PLEASE ONLY ENTER AN INTEGER VALUE AND NOT 0---------------------");
                Console.WriteLine(question);
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    num = 0;

                }}
            

            return num;
        }
    
    

        public String getMeasurementUnit()
        {
            String unit = null;
            int option = 0;

            Console.WriteLine("What type of unit of measurement are you using:\n" +
                "(1)ml\n(2)grams");
            option = Convert.ToInt32(Console.ReadLine());


            return unit;
        }
    }
 }

