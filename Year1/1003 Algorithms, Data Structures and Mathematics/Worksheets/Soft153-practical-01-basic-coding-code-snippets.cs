				
using System;

// note -- the formating of this file is not ideal ... not the best programming practice ... 

/* to start with: 
   code should be consistently indented
   empty lines and horizontal space can be used to make the structure of code visible 
   functions and variables should have cognitively accessible names and use a consistent naming strategy
 */


class Program { 


	// task 7
    static void swap ( ref int x, ref int y ) {
		int temp;
		temp = x;
		x = y;
		y = temp;
    }

    static void wrong_swap ( int x, int y ) {
		int temp;
		temp = x;
		x = y;
		y = temp;
    }
	
	// task 13
	static int min_of_array( int[] a, int n ) {
		int i, min = a[0];
		for( i=1; i<n; i++) 
			if ( a[i] < min )
				min = a[i];
		return ( min );
	}
	
	// task 14 
	static void copy_array( int[] a, int[] b, int n ) {
		int i;
		for( i=0; i<n; i++)
			b[i] = a[i] ;
	}

	                        
    static void Main() {  
		int i;
 
		
	// 1.Write the string “Hello World” to the console
		
		System.Console.WriteLine( "Hello World");

			
	// 2.Write the value of an integer variable to the console
		
		i = 1;
		System.Console.WriteLine(  i  );

				
	// 3.Write some text followed by an integer to the console (using one Write statement alone)
		
		i = 5;
		System.Console.WriteLine(  "The value of variable i is:" +  i  );
				
	// 4.Read an integer from the console 
				
	//	i = int.Parse( Console.ReadLine() );
	//	System.Console.WriteLine(  "The value of variable i is now:" +  i  );

				
	// 5.Sum the numbers from 1 to 10 using a for-loop
		
		int sum = 0;
		for( i=1; i<=10; i++) 
			sum = sum + i; 
		System.Console.WriteLine(  "for-loop:  The sume 1+2+3...+10 is:" +  sum );


	// 6.Sum the numbers from 1 to 10 using a while-loop

		sum =0;
		i=1;
		while( i <= 10 )
		{
			sum = sum + i;
			i = i+1;
		}
		System.Console.WriteLine(  "while-loop:  The sume 1+2+3...+10 is:" +  sum );
		

	// 7.Fill an integer array of size 10 with random numbers in the range from 0 to 19

		int[] a = new int[10];
		Random r = new Random();
		
		for( i=0; i<10; i++) 
			a[i] = r.Next(20) ;
		
		// control output
		for( i=0; i<10; i++) 
			System.Console.Write( a[i] +"  " );
		System.Console.WriteLine();
		
	// 8.Find the minimum of the array in 7
		int min = a[0];
		for( i=1; i<10; i++) 
			if ( a[i] < min )
				min = a[i];
		System.Console.WriteLine(  "minimum:  The minimum value in the array is:" + min );


	// 9.Linear search: Write code that searches for a value, say “5”,  
	// in the array from task 7 by going through the array from beginning to the end  
	// and comparing the search value with the values in the array. If the value is found print 
	// “The value has been found” otherwise print “The value has not been found”.  This will need a for-loop and an if-then-else statement.

		bool isFound=false;
		int searchValue = 5;
		for( i=0; i<10; i++ ) 
			if ( a[i] == searchValue ) {
				isFound = true;
				break;
			}
		if (isFound == true)
			System.Console.WriteLine(  "The value has been found" );
		else
			System.Console.WriteLine(  "The value has not been found" );

		
	// 10.Swap the values of two integers
		
		// declare the variables
		int x, y, temp;
		
		//initialise the variables
		x = 1;
		y = 2;

					System.Console.WriteLine(  "before swap: x is " + x + " ;  y is " + y );

		// swap the values
		temp = x;  // save storage not to loose the alue of x
		x = y;
		y = temp;
		
					System.Console.WriteLine(  "after swap: x is " + x + " ;  y is " + y );
			
	// 11.Copy the content of one array into another using a for-loop (don't use Array.Copy()) 
		
		int[] b = new int[ 10 ];
		// we also use the a-array from task 7
		
		// now copy a to b 
		for( i=0; i<10; i++)
			b[i] = a[i] ;
		

	// 12. Write a function that swaps two integers
		
		// see beginning of file, line 8 
		
		// this is, how to call the function:
		
		System.Console.WriteLine(  "before wrong_swap function call : x is " + x + " ;  y is " + y );
		
		// this function swaps nothing because only values are passed to the function
		wrong_swap ( x, y ) ;

		System.Console.WriteLine(  "before swap function call : x is " + x + " ;  y is " + y );
				
		// this function swaps, because the references to the variables are passed to the function
		swap ( ref x, ref y ) ;

		System.Console.WriteLine(  "after swap function call : x is " + x + " ;  y is " + y );


	// 13.Write a function that returns the maximum of an integer array
		
		// see top fo file, line 
		 min = min_of_array( a, 10 ); // array a has 10 elements 
		
		System.Console.WriteLine(  "minimum function : The minimum of array a is " + min );

	// 14.Write a function that takes two arrays “source” and “dest” and copies “source” to “dest” (don't use Array.Copy()) 
		
		// see line 31
		copy_array( a, b, 10 ); // copies a to b; 10 elements 

	// 15.If a, b, c are bool-variables, a is true, but b and c are false, write an expression that computes the logical 
    // value of  ( a && b ) || c, assign it to a bool d, and depending on the result print “d is true” or “d is false”. 
	// What does  “( a && b ) || c” mean?

		// a and b are already defined in this scope; need differen tnames ...
		bool A = true, B = false, C = false; 
		bool D = ( A && B ) || C ;
		if (D == true)
			System.Console.WriteLine( "D is true" ); 
		else
			System.Console.WriteLine( "D is false" ); 
		
	// 16.Write code that evaluates all possible assignments of truth values to a, b, c in task 15 and print the result of  ( a && b ) || c.
		
		// .. left as an exercise 
	}			
}
	
