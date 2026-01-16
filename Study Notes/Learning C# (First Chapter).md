##### Learning C# (First Chapter)



1- Console can also read input received from the user



Console.ReadLine()



This will force the console to read an input received by the user



2-Developers can also add some message for them selves or for other developers



-Providing Context for written Code

-Help other developers to understand the code quicker

-Comment code out to see how the program will run without it



Short one lines will be written with //

Large message will be written /\*\*/



##### **Data Types (Second Chapter)**



1-C# is strongly-typed, meaning it requires us to specify the data types for values that we’re using.

It is also statically-typed, which means it will check that we used the correct types before the program even runs.





**2-Data Types**



* **int -** whole numbers, like: 1, -56, 948
* **double -** decimal numbers, like: 239.43909, -660.01
* **char -** single characters, like: “a”, “\&”, “£”
* **string -** string of characters, like: “dog”, “hello world”
* **bool -** boolean values, like: true or false



3- Variables declared with var are still strongly-typed - the compiler simply infers the type at compile time, not runtime.



**4-Converting Data Types:**



**Data type conversion.**



* **Implicit conversion:** happens automatically if no data will be lost in the conversion. That’s why it’s possible to convert an int (which can hold less data) to a double (which can hold more), but not the other way around.



* **explicit conversion:** requires a cast operator to convert a data type into another one. If we do want to convert a double to an int, we could use the operator (int).





using System;



namespace FavoriteNumber

{

  class Program

  {

    static void Main(string\[] args)

    {

      // Ask user for fave number

      Console.Write("Enter your favorite number!: ");



      // Turn that answer into an int

 

      // Attempt 1: use implicit conversion

      **// int faveNumber = Console.ReadLine();**

 

      // Attempt 2: use explicit conversion

&nbsp;     \*\*// int faveNumber = (int)Console.ReadLine();\*\*


 

      // Attempt 3: use Convert method

&nbsp;     \*\*int faveNumber = Convert.ToInt32(Console.ReadLine());\*\*


    }

  }

}



##### **Numerical Data Types (Third Chapter)**



* **Int-** Whole integer Values that does not require decimals
* **Double-** Is usually the best choice of the 3 because its more precise than a float , but faster to process than a decimal. (Double can be written with a d at the back of the value)
* **Decimal-** Should be used for Financial applications (Have a m written on the back of the value)
* **Float-** (Should have a f written on the back of the value)







#### Arithmetic Operators



Arithmetic operators include:



addition +

subtraction -

multiplication \*

division /



When two different numerical types are used with an arithmetic operator, the result will always be of the type that is more precise. So, if we use an int with a double, the result will be a double.



* Parentheses: () — Operators within parentheses will be assessed before those outside parentheses. If one set of parentheses is nested within another, the nested group will be assessed before the outer group.



* Multiplicative: \*, /, % — % is the modulo operator, which we will cover later in this lesson.



* Additive: +, -



int answer = 1 + 2 \* 3; // 7 - multiplication is assessed first based on operator precedence

answer = 1 + (2 \* 3);   // 7 - multiplication is assessed first because it is in parentheses

answer = (1 + 2) \* 3;   // 9 - addition is assessed first because it is in parentheses





##### Operator Shortcuts



Often, we need to update a variable in our program. We can do so by modifying that variable using an arithmetic expression, then re-saving it to the same variable name:



When updating a value the long way you will write it like this



Apple= apple +2;



++  Increment Operator (To take value plus 1)

-- Decrement Operator (To take value mins 1)



When using the above operators it will look like this



Apple++;

Apple--;





When you want to increment by a value besides 1, say 3 , we can do the following



Variable += 3; then the program will increase the original variable value with 3



This syntax can also be used with the multiplication, division and decrementing





. \*= 3 will multiply the variable’s value by 3 and reassign the result to the variable. /= 3 will do the same with division.

Collectively, +=, -=, \*=, and /= are known as compound assignment operators.



##### Modulo



* Modulo is useful because it lets us know if a number “fits” into a larger number, or if there will be a remainder.
* It can also be used to check if a number is odd or even. If a number is even, taking its modulo with 2 will return a 0, and if it is odd it will return a 1:



Modulo can be identified as %



##### Built-In Methods



* Math.Abs() — Finds the absolute value of a number. Example: Math.Abs(-5) returns 5.
* Math.Sqrt() — Finds the square root of a given double. Example: Math.Sqrt(16) returns 4.
* Math.Floor() — Rounds the given double or decimal down to the nearest whole number. Example: Math.Floor(8.65) returns 8.
* Math.Ceiling() — The counterpart of Math.Floor(), rounds a given double or decimal up to the nearest whole number. Example: Math.Ceiling(8.65) returns 9.
* Math.Min() — Returns the smaller of two numbers of the same type. Example: Math.Min(39, 12) returns 12.
* Math.Max() — The counterpart of Math.Min(), returns the larger of two numbers of the same type. Example: Math.Max(39, 12) returns 39.



As such, the built-in method Math.Sqrt() can only process a positive number as a value. Otherwise, it will yield NaN. The value of numberTwo is negative, but we can still make our program work by finding its absolute value first, then square-rooting the result.





##### **Introduction to Working with Text (Fourth Chapter)**



### Escape Character Sequences



What happens when you need to include quotes in a string? You can use an escape sequence. An escape sequence places a backslash (\\) before the inner quotation marks so the program doesn’t read them accidentally as the end of the sequence.



string withSlash = "Ifemelu said, \\"Hello!\\""; (Including the back slashes will allow the program to write the text with the ""



We can use escape character sequences to create a new line. That means that when we print the string to the console, it will print that line below the rest. If printed on its own, it will create an empty line. To make a new line, use the character combination \\n.





**Concatenation**

A common way to do this is by using string concatenation. String concatenation is when we combine strings using the addition symbol (+), literally adding one string to another.



**Interpolation**

Notice how we just have one string, which we prepend with the dollar sign symbol $. Ensure there is no space between the $ and the starting quotation mark ". Whenever we need to insert a variable, we surround it with braces {}.

