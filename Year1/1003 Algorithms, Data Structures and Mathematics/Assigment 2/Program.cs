using System;
//Morgan Hodge
//70% CourseWork
//Student ID:10779528

class Program
{
    static void Main(string[] args)
    {

        int[] S = new int[5] { 9, 3, 5, 1, 2 };   //Set Creation

        Console.WriteLine("Printing set");
        int length = Functions.size(S);

        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(S[i]);
        }

        Functions.Clear_Set(S);      // no ref, set is unedited for future functions

        Functions.is_empty(S);
        Console.WriteLine("Returning size");
        Functions.size(S);
        Console.WriteLine(length);
        Functions.capacity(S);       
        Functions.is_element_of(S);
        Functions.print(S);
        Functions.add(ref S);

        Functions.remove(ref S);
        Functions.copy(S);


    }

}

public class Functions
{


    public static void Clear_Set(int[] S)
    {
        Console.WriteLine("Clear Set");
        S = new int[0];
        int length = Functions.size(S);
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(i);

        }
    }


    public static bool is_empty(int[] S)
    {
        Console.WriteLine("Checking if empty");
        int number = 0;

        int length = Functions.size(S);

        for (int i = 0; i < length; i++)    //Runs for amount of elements in S
        {
            number++;           //Increases number counter for each element
        }
        if (number == 0)          //Boolean checker 
        {
            Console.WriteLine("true");
            return true;
        }
        else
        {
            Console.WriteLine("false");
            return false;
        }
    }


    public static int size(int[] S)
    {
        

        int Length = 0;
        int Test = 0;

        while (true)
        {
            try
            {
                Test = S[Length];
                Length++;
            }
            catch (Exception)
            {

                break;
            }

        }
        return Length;
    }


    public static int capacity(int[] S)
    {

        int Length = 0;
        int Test = 0;

        while (true)
        {
            try
            {
                Test = S[Length];
                Length++;
            }
            catch (Exception)
            {

                break;
            }

        }
        return Length;

    }


    public static bool is_element_of(int[] S)
    {
        Console.WriteLine("Checking if x is an element of set S");
        int x = 9;                       //Declaring X variable
        int number = 0;
        int length = Functions.size(S);

        for (int i = 0; i < length; i++) //Runs through the integer in S
        {
            number++;                    //Increases number counter for each element
        }
        for (int i = 0; i < number; i++)
        {
            if (S[i] == x)               //Checks if values of S = X
            {
                Console.WriteLine("true");
                return true;
            }
        }

        Console.WriteLine("false");
        return false;

    }



    public static void print(int[] S) 
    {
        Console.WriteLine("Printing set in arbitrary order");
        int length = Functions.size(S);
        int number = 0;

        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(S[number]);
            number++;
        }
    }
    



    public static void add(ref int[] S)
    {
        Console.WriteLine("Adding x to set");
        int x = 4;
        int number = 0;
        bool present = false;
        int length = Functions.size(S);


        for (int i = 0; i < length; i++)  //Runs through the integers in S
        {
            if (S[number] == x)
            {
                present = true; 
            }
            number++;                    //Increases number counter for each element
        }
        if (present==false)
        {
            int[] secondary = new int[number];


            for (int i = 0; i < number; i++)
            {
                secondary[i] = S[i];
            }

            S = new int[number + 1];
            for (int i = 0; i < number; i++)
            {
                S[i] = secondary[i];
                Console.WriteLine(S[i]);
            }
            S[number] = x;
            Console.WriteLine(S[number]);
        }
        else
        {
            int numberCount = 0;
            
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(S[numberCount]);
                numberCount++;
            }
        }
       
    }
 
    public static void remove(ref int[] S)
    {
        Console.WriteLine("Removing x from set");
        int x = 7;
        int number = 0;
        bool present = false;
        int length = Functions.size(S);


        for (int i = 0; i < length; i++)  //Runs through the integers in S
        {
            if (S[number] == x)
            {
                present = true;
            }
            number++;                   //Increases number counter for each element
        }
        if (present == true)
        {
            int[] secondary = new int[number];


            for (int i = 0; i < number; i++)
            {
                secondary[i] = S[i];
            }

            S = new int[number - 1];
            int counter = 0;
            for (int i = 0; i < number; i++)
            {
                if (secondary[i]!=x)
                {
                    S[counter] = secondary[i];
                    Console.WriteLine(S[counter]);
                    counter++;
                }
           
            }
        }
        else
        {
            int numberCount = 0;

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(S[numberCount]);
                numberCount++;
            }
        }

    }


    public static int[] copy(int[] S)
    {
        Console.WriteLine("clone of set");
        int length = Functions.size(S);

        int[] cloneset = new int[length];
        for (int i = 0; i < length; i++)
        {
            cloneset[i] = S[i];
        }
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(cloneset[i]);
        }
        return cloneset;
    }
}
//I had a lot of peronal issues occur near the due date of this assigment, because of this -
//I was unable to complete the remaning section of the work
