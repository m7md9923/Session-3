namespace Session_3_a;

class Demo
{
    static void Main(string[] args)
    {
        // any type
        // T --> placeholder for any type
        // T: value type or reference type --> based on val passed  
        static void Print<T>(T val)
        {
            Console.WriteLine(val);
        }
        
        static void Test_print()
        {
            // boking --> convert from value type to reference type
            // unboking -- > convert from reference type to value type
            Print(10);
            Print<int>(10);
            Print("mohamed");

        }

        static void Print_obj(object obj)
        {
            Console.WriteLine(obj);
        }

        static void Test_printobj()
        {
            Print_obj(10);
            Print_obj("mohamed");
            Print_obj(10.5);
        }

        static void Main(string[] args)
        {
            #region object
            
            // cons of object:
            // 1- it requires boxing and unboxing --> this decrease performance
            // 2- saftey --> u can pass any type to it --> this requires casting 
            //
            
            //  object obj
            // refer to null 
            // can refer to any instance of object or datatype that ihiret from object  
            
            // int x = 100;
            // object obj = x;
            // obj = new object();
            // obj = "mohamed";
            // int res = (int)obj+ 100; // casting
            // Console.WriteLine(res);
            // int y = (int)obj; // unboking 
            //
                #region methods
                
                #region tostring()
                
                // Point p1 = new Point() {x = 10, y = 20};
                // Console.WriteLine(p1.ToString());  // Session_3.Point --> due to coming from object
                // object obj = 9876;
                // Console.WriteLine(obj.ToString()); // 9876 --> int make override to tostring() but class point do not
                // int x = 9876;
                // Console.WriteLine(x.ToString()); // 9876 --> because this come from int : behavior change based on type
                
                #endregion
                
                #region equals()
                
                // Point p1 = new Point() {x = 10, y = 20};
                // Point p2 = new Point() {x = 10, y = 20};
                // Console.WriteLine(Equals(p1 , p2)); // False --> because this compare references not values
                // p1 = p2; // p1 , p2 indicate to the same reference
                // Console.WriteLine(Equals(p1, p2)); // True --> because this compare references 

                // int x = 1234 , y = 1234; // value types do not have references
                // Console.WriteLine(Equals(x, y)); // True --> because this compares values 

                // object obj1 = 1234 , obj2 = 1234;
                // Console.WriteLine(obj1.Equals(obj2)); // True --> because this compares values
                //
                #endregion
                
                #region GetHashCode()
                
                // Point p1 = new Point() {x = 10, y = 20};
                // Point p2 = new Point() {x = 10, y = 20};
                // Console.WriteLine(p1.GetHashCode());  //32854180
                // Console.WriteLine(p2.GetHashCode());  //27252167
                // p1 = p2; // both refer to the same address
                // Console.WriteLine(p1.GetHashCode());  //27252167
                // Console.WriteLine(p2.GetHashCode());  //27252167
                //
                // int x = 1234 , y = 1234;   // value types 
                // Console.WriteLine(x.GetHashCode());  // 1234
                // Console.WriteLine(y.GetHashCode());  // 1234  --> dose not cotain heap (value type)
                #endregion
                
                #region GetType()
                // Point p1 = new Point() {x = 10, y = 20};
                // Point p2 = new Point() {x = 10, y = 20};
                // Console.WriteLine(p1.GetType());  // Session_3.Point
                // Console.WriteLine(p2.GetType());  // Session_3.Point
                // int x = 1234 , y = 1234;   
                // Console.WriteLine(x.GetType());  // System.Int32
                // Console.WriteLine(y.GetType());  // System.Int32
                //
                // string name = "mohamed";
                // object obj = name;  // upcasting --> string inherit from object class --> make child and set parent = child
                // Console.WriteLine(obj.GetType());  // System.String --> return real type: check type at runtime 
                //
                #endregion
                
                #endregion

                #endregion
                
            #region Fraction & discard
            
            // Float: 
            
            // float x = 12.3456; //invalid casting and 12.3456 : double because this is default in c# 
            //float y = 12.3456F; //valid 
            // float z = 10; // valid
            // Console.WriteLine(z);
            
            // float x = 3 / 2; // 1
            // Console.WriteLine(x);
            // float y = 3 / 2F; // 1.5
            // y = 3F / 2;   // 1.5
            // Console.WriteLine(y);
            
            // Decimal:
            
            //decimal a = 10.12345; // invalid
            // decimal b = 10.12345M; // valid casting
            // Console.WriteLine(b);
            
            
            // Discard  , Digit separator [_]  c# 7.0 feature : for readability

            // int num = 100_00_00; // separator does not appear in print
            // Console.WriteLine(num);
            
            // discard second parameter in this func
            // int.TryParse(Console.ReadLine(), out _);

            // int num = 100000000;
            // Console.WriteLine($"{num:c}");  // string interpolation
            
            #endregion
            
            #region Implicit & Explicit Casting
            
            // Implicit Casting [safe casting]
            //
            // int x = 100; // 4 bytes in stack 
            // long y; // 8 bytes in stack 
            // y = x;
            // // x = y; // invalid  [explicit casting] unsafe
            // y = 1000000000000000000;
            // x = (int)y; // arthmetic overflow

            // how handle : 
            
            // long x = 1000000000000000000;
            // try
            // {
            //     checked
            //     {
            //         int y = (int)x;
            //         unchecked
            //         {
            //             Console.WriteLine(y);
            //         }
            //     }
            // }
            // catch(OverflowException e)
            // {
            //     Console.WriteLine(e.Message);
            // }

            // Object x = 1000;
            // if (x.GetType() == typeof(int))
            //     Console.WriteLine(x);
            // else
            //     Console.WriteLine("Num is large");
            
            // [int - float ]
            
            // implicit   int --> float
            //
            // int x = 10;
            // float y = x; // valid casting
            // Console.WriteLine(y); // 10
            
            // // explicit  float --> int
            // float x = 10.5F;
            // int y = x; // invalid casting
            //
            // y = (int)x;
            // Console.WriteLine(y);

            #endregion
            
            #region Casting [Convert-Parse-TryParse]
            
            #region convert
            // Console.WriteLine("Please enter a number: ");
            // Console.WriteLine("name");
            // string input = Console.ReadLine();
            // Console.WriteLine("age");
            // int age = Convert.ToInt32(Console.ReadLine());
            // //int? x = null;  // nullable type
            // Console.WriteLine("salary");
            // double salary = Convert.ToDouble(Console.ReadLine());
            // Console.Clear();
            // Console.Beep(1000 , 3000);
            // Console.WriteLine("Name: " + input);
            // Console.WriteLine("Age: " + age);
            // Console.WriteLine("Salary: " + salary);
            
            #endregion
            
            #region parse
            // both convert & parse work in good secnario not in worst 
            // Console.WriteLine("Please enter a number: ");
            // Console.WriteLine("name");
            // string input = Console.ReadLine();
            // Console.WriteLine("age");
            // int age = int.Parse(Console.ReadLine()); 
            // //int? x = null;  // nullable type
            // Console.WriteLine("salary");
            // double salary = Double.Parse(Console.ReadLine());
            // Console.Clear();
            // Console.Beep(1000 , 3000);
            // Console.WriteLine("Name: " + input);
            // Console.WriteLine("Age: " + age);
            // Console.WriteLine("Salary: " + salary);
            #endregion
            
            #region TryParse
            // Console.WriteLine("Please enter a number: ");
            // Console.WriteLine("name");
            // string input = Console.ReadLine();
            // Console.WriteLine("age");
            // int age;
            // bool isAgeParsed = int.TryParse(Console.ReadLine() ,out age);
            // //int? x = null;  // nullable type
            // Console.WriteLine("salary");
            // bool isSalaryParsed = Double.TryParse(Console.ReadLine() , out double salary);
            // Console.Clear();
            // Console.Beep(1000 , 3000);
            // Console.WriteLine($"isAgeParsed = {isAgeParsed}");
            // Console.WriteLine("Name: " + input);
            // Console.WriteLine("Age: " + age);
            // Console.WriteLine($"isSalaryParsed = {isSalaryParsed}");
            // Console.WriteLine("Salary: " + salary);
            #endregion

            #endregion

            #region Unary op
            //int x = 10;
            #region Increment 
            // // 1- prefix  --> increment then print  
            // Console.WriteLine(++x); // 11
            // // 2- postfix --> print then print incerment
            // Console.WriteLine(x++); // 10
            #endregion
            
            #region Decrement 
            // // 1- prefix  --> decrement then print  
            // Console.WriteLine(--x); // 9
            // // 2- postfix --> print then print decrement
            // Console.WriteLine(x--);  // 10
            #endregion
            
            #endregion

            #region bin / arethmetic op
            //
            // int a = 10, b = 4;
            // Console.WriteLine(a+b); // 14
            // Console.WriteLine(a/b); // 2
            // Console.WriteLine(a%b); // 2
            // // onother way to compute modulus
            // Console.WriteLine(a -(a/b)*b); // 2
            //
            // // even  n%2 == 0
            // // odd   n%2 != 0   

            #endregion

            #region assign op

            //int a = 10;
            // assign only
            //  a = 5;
            // Console.WriteLine(a); // 5
            
            // add & assign
            // a += 2; 
            // Console.WriteLine(a); // 7
            // a -= 3; 
            // Console.WriteLine(a); // 4

            //a = 5;
            // mul & assign
            // a *= 2;
            // Console.WriteLine(a); // 10
            //  a /= 2;
            // Console.WriteLine(a); // 5
            // a %= 5;
            // Console.WriteLine(a); // 0
            

            #endregion
            
            #region comparsion op [relational op]
            
            // int a = 10, b = 5;
            // // equal
            // Console.WriteLine("a == b ? " + (a == b)); // flase
            //
            // // not equal
            // Console.WriteLine("a != b ? " + (a != b));  // true
            //
            // // greater than 
            // Console.WriteLine("a > b ? " + (a > b));  // true
            //
            // // less than 
            // Console.WriteLine("a < b ? " + (a < b));  // false
            //
            // // greater than or equal 
            // Console.WriteLine("a >= b ? " + (a >= b));  // true
            //
            // //less than or equal 
            // Console.WriteLine("a <= b ? " + (a <= b));  // false
            #endregion
            
            #region logical op
            
            // bool a = true, b = false;
            // Not op
            // !1 --> 0
            // !0 --> 1
            //Console.WriteLine("(!a)" + !a);
            

            // logical And [short circuit]
            // 1 && 1 == 1
            // 1 && 0 == 0
            // 0 && 0 == 0
            //Console.WriteLine("(a && b : " + (a && b));

            //logical OR [short circuit --> not require check all]
            // 1 || 1 = 1
            // 1 || 0 = 0

            //Console.WriteLine("(a || b : "+ (a || b));

            #endregion
            
            #region bitwise op

            // // Bitwise AND
            // //     1011
            // //     0110
            // //res: 0010
            // int a = 5, b = 4; // a --> 101 , b = 100
            // Console.WriteLine(a & b); // 1 --> 100
            //
            // // Bitwise OR
            // // both true then or --> true
            // Console.WriteLine(a|b); // 1 --> 101
            //
            // // XOR
            // // both true or both false --> xor: false 
            // // both not equal -> xor: true
            // Console.WriteLine(a^b); // 1 --> 1
            //
            // // NOT --> invert all digits
            // Console.WriteLine(~a); // 2s complement --> -6
            //
            // // shift left //  *2
            // Console.WriteLine(a << 1); // 1010
            //
            // // shift right  //  [/2]
            // Console.WriteLine(a >> 1);  // 10
            //
            // search 
            // a >>> 1 --> unsigned shift right
            
            #endregion
            
            #region ternary op

            // int a = 10, b = 5;
            // string res = (a > b ? "a > b" : "b > a");
            //

            #endregion

            #region piriority op

            // int a = 10, b = 20, c = 30;
            // int res = a - b * c; // * first --> then subtract 
            // Console.WriteLine(res); 
            //
            // res = (a - b) * c;
            // Console.WriteLine(res);
            //
            // res = a + b * c / a; // * / +
            // Console.WriteLine(res);
            //
            // res = (a + b) % c;
            // Console.WriteLine(res);
            //
            // int q6 = a + b++; // 30
            // Console.WriteLine(q6);
            // q6 = a +++ b;  // 31
            // Console.WriteLine(q6);
            
            
            #endregion

            #region string formatting

            // string interpolation 
            // // equ -- > 10+5
            // int a = 10, b = 20, res= a+b;
            // string msg = $"equ : {a}+{b} = {res}";
            // Console.WriteLine(msg);


            #endregion


            #region control stat

            // conditional stat 
            // int a = 10, b = 20;
            // if (a > b) a++;
            // else if (b > a) b++;
            // else
            // {
            //     a++; b++;
            // }
            //
            // //switch 
            //     
            // // looping / interation stat 
            // for (int i = a; i <= b; i++)
            // {
            //     Console.WriteLine(i);
            // }
            //
            // while (a < b)
            // {
            //     Console.WriteLine(a);
            //     a++;
            // }
            //
            // for (int i = a; i <= b; i++)
            // {
            //     if (i % 2 == 0) break;
            // }
            //
            // // jumbing stat

            #endregion


        }
    }
}
