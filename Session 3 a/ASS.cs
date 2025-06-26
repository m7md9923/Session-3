namespace Session_3;

class Program
{
    static void Main(string[] args)
    {
        #region Question 1
        // /*
        //     Write a program that allows the user to enter a number then print it.
        // */
        // Console.WriteLine("Plz Enter a number: ");
        // int num;
        // bool isNum = int.TryParse(Console.ReadLine(), out num);
        // if(isNum) 
        //     Console.WriteLine($"The Num is : {num}");
        // else 
        //     Console.WriteLine("Invalid Input");
        #endregion

        #region Question 2

        // /*
        //   Write C# program that converts a string to an integer, but the string contains non-numeric characters.
        //   And mention what will happen 
        // */
        // Console.WriteLine("Plz Enter a string: ");
        // string str;
        // str = Console.ReadLine();
        // int num;
        // bool check = int.TryParse(str , out num);
        // if(check) 
        //     Console.WriteLine($"The Num is : {num}");
        // else
        //     Console.WriteLine("Invalid Input");
        //
        // /*
        //     if u enter non numeric data --> format exception when u do not handle it 
        //     when use TryParse() --> if string contain non numeric data func returns False  else returns True   
        // */
        //
        #endregion
        
        #region Question 3
        // /*
        //  * Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
        //  */
        //
        // double num1 = 10.7; 
        // double num2 = 5.4;
        // double add = num1 + num2;
        // double sub = num1 - num2;
        // double mul = num1 * num2;
        // double div = num1 / num2;
        // Console.WriteLine($"sum : {add}");
        // Console.WriteLine($"subtract : {sub}");
        // Console.WriteLine($"multiply : {mul}");
        // Console.WriteLine($"divide : {div}");
        //
        // // what happen ? 
        // // work normally and print floating point result 
        // not highly precision --> if u want this u must use decimal intead of double
        #endregion
        
        #region Question 4
        /*
         Write C# program that Extract a substring from a given string. (Search)
         */
        // Console.WriteLine("Plz Enter a string: ");
        // string str = Console.ReadLine();
        // Console.WriteLine("Plz Enter a substring to extract : ");
        // string substr = Console.ReadLine();
        //
        // int l = 0, r = 0;
        // bool found = false;
        // while (r < str.Length)
        // {
        //     if (str[r++] == substr[l++])
        //     {
        //         if (l == substr.Length)
        //         {
        //             found = true;
        //             break;
        //         }
        //     }
        //     else
        //     {
        //         r -= l - 1;
        //         l = 0;
        //     }
        // }
        // if(found)
        //     Console.WriteLine("Substring is found");
        // else
        //     Console.WriteLine("Not Found");
        //
        #endregion
        
        #region Question 5
        // /*
        //     Write C# program that Assigning one value type variable to another 
        //     and modifying the value of one variable and mention what will happen
        //  */
        // int a = 10;
        // int b = a;  // copy from a value
        //
        // Console.WriteLine("Before modification:");
        // Console.WriteLine($"a = {a}"); // 10
        // Console.WriteLine($"b = {b}");  // 10
        // b = 20; 
        // Console.WriteLine("After modifying b:");
        // Console.WriteLine($"a = {a}");  // 10
        // Console.WriteLine($"b = {b}");  // 20
        
        #endregion
        
        #region Question 6
        // /*
        //  Write C# program that Assigning one reference type variable to another
        //  and modifying the object through one variable and mention what will happen
        //  */
        //
        // object obj1 = 10 , obj2 = 20;
        // obj2 = obj1;  // both reference the same boxed value
        //
        // Console.WriteLine("Before modification:");
        // Console.WriteLine($"abj1 = {obj1}"); // 10
        // Console.WriteLine($"obj2 = {obj2}");  // 10
        //
        // obj2 = 20; //  new boxed object containing 20 is created and obj2 points to it.
        //
        // Console.WriteLine("After modifying b:");
        // Console.WriteLine($"abj1 = {obj1}"); // 10
        // Console.WriteLine($"obj2 = {obj2}");  // 20

        #endregion

        #region  Question 7
        
        // /*
        //  Write C# program that take two string variables and print them as one variable 
        // */
        // Console.WriteLine("Plz Enter the first string: ");
        // string str1 = Console.ReadLine();
        // Console.WriteLine("Plz Enter the second string: ");
        // string str2 = Console.ReadLine();
        // Console.WriteLine(str1 + str2);

        #endregion
        
        #region Question 8
        
        // /*
        //  Write a program that calculates the simple interest given the principal amount, 
        //  rate of interest, and time. The formula for simple interest is 
        // Interest = (principal * rate * time ) /100.
        // */
        // double amount , rate , time;
        // Console.WriteLine("plz Enter the amount : ");
        //
        // while (!Double.TryParse(Console.ReadLine(), out amount) || amount < 0)
        // {
        //     Console.WriteLine("invalid amount. Try again");
        // }
        //
        // Console.WriteLine("plz Enter the rate of interrest :");
        // while (!Double.TryParse(Console.ReadLine(), out rate) || rate < 0)
        // {
        //     Console.WriteLine("invalid amount. Try again");
        // }
        //
        // Console.WriteLine("plz Enter the time :");
        // while (!Double.TryParse(Console.ReadLine() , out time) || time < 0)
        // {
        //     Console.WriteLine("invalid amount. Try again");
        // }
        //
        // double interest = (amount * rate * time) / 100;
        // Console.WriteLine($"Simple Interest is : {interest}");
        #endregion

        #region  Question 9

        // /*
        //   Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms
        //   and height in meters. The formula for BMI is
        //   BMI = (Weight)/(Height*Height)
        //  */
        //
        // double weight, height;
        //
        // Console.Write("plz Enter ur weight in kilograms: ");
        // while (!double.TryParse(Console.ReadLine(), out weight) || weight <= 0)
        // {
        //     Console.Write("Invalid input. Please enter a positive num : ");
        // }
        //
        // Console.Write("plz Enter ur height in meters: ");
        // while (!double.TryParse(Console.ReadLine(), out height) || height <= 0)
        // {
        //     Console.Write("Invalid input. Please enter a positive num : ");
        // }
        //
        // double bmi = weight / (height * height);
        // Console.WriteLine("BMI =  "+bmi);
        #endregion
        
        #region Question 10
        
        // /*
        //     Write a program that takes the date from the user and displays it in various formats using string interpolation. (Search)
        //     Ex:
        //     Today’s date : 20 , 11 , 2001
        //     Today's date : 20 / 11 / 2001
        //     Today's date : 20 – 11 – 2001
        //  */
        //
        // int day, month, year;
        //
        // Console.Write("Enter day: ");
        // while (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 31)
        // {
        //     Console.Write("Invalid input. Enter day (1-31): ");
        // }
        //
        // Console.Write("Enter month: ");
        // while (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12)
        // {
        //     Console.Write("Invalid input. Enter month (1-12): ");
        // }
        //
        // Console.Write("Enter year: ");
        // while (!int.TryParse(Console.ReadLine(), out year) || year < 1)
        // {
        //     Console.Write("Invalid input. Enter year: ");
        // }
        // Console.WriteLine($"Today's date : {day} , {month} , {year}");
        // Console.WriteLine($"Today's date : {day} / {month} / {year}");
        // Console.WriteLine($"Today's date : {day} - {month} - {year}");
        
        
        // // another way 
        
        // Console.Write("Enter date (e.g. 2025-06-26): ");
        // DateTime date = DateTime.Parse(Console.ReadLine());
        //
        // Console.WriteLine($"Today's date : {date.Day} , {date.Month} , {date.Year}");
        // Console.WriteLine($"Today's date : {date.Day} / {date.Month} / {date.Year}");
        // Console.WriteLine($"Today's date : {date.Day} - {date.Month} - {date.Year}");
        
        #endregion
        
        #region Question 11
        
        /*
         * Console.WriteLine($"The event is on {date:MM/dd/yyyy}");
             a-The event is on 14/06/2024
             b-The event is on 2024-06-14
             c-The event is on 06/14/2024
             d-The event is on June 14, 2024
         */
        
        // output : c
        
        #endregion

        #region Question 12

        /*
        Which of the following statements is correct about the C#.NET code snippet given below?
            int d; 
            d = Convert.ToInt32( !(30 < 20) );
            A value 0 will be assigned to d.
            A value 1 will be assigned to d.
            A value -1 will be assigned to d.
            The code reports an error.
            The code snippet will work correctly if ! is replaced by Not.
         */
        
        // output : A value 1 will be assigned to d.

        #endregion
        
        #region Question 13
        
        /*
        Which of the following is the correct output for the C# code given below?
        Console.WriteLine(13 / 2 + " " + 13 % 2); 
        a-6.5 1
        b-6.5 0
        c-6 0
        d-6 1
        e-6.5 6.5
        */
        // output : d) 6 1
        
        #endregion
    }
}