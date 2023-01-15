using System;

namespace MathsProgram

{

    public class Program 

    {

        // all the functions are defined  here

            public static void sum() // function for addition
         {
            //int a, b, add;

            Console.WriteLine(" Enter Two Numbers:: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int add;
            add = a + b;
            Console.WriteLine(" The Sum  is =  " + add); 
        }

            public static void sub() // function for substraction
        {
            //int a, b, z;

            Console.WriteLine(" Enter Two Numbers:: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int z;
            z = a - b;
            Console.WriteLine("Subraction =  " + z); 
        }

            public static void mul() // multiplication function
        {
            //int a, b, y;

            Console.WriteLine(" Enter Two Numbers:: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int y;

            y = a * b;
            Console.WriteLine("Multiplication =  " + y); 
        }

            public static void div() // division function
        {
            //int a, b, g;

            Console.WriteLine(" Enter Two Numbers:: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
 
            int g;
            g = a / b;
            Console.WriteLine("Division =  " + g); 
        }


            public static void sqrt() // method for square root calculation
{

                Console.WriteLine("Enter a Number : ");
                int Number = Convert.ToInt16(Console.ReadLine());
                double SqrtNumber = Math.Sqrt(Number);
                Console.WriteLine("Square root of {0} is: {1}", Number, SqrtNumber);
                Console.ReadLine();
}

     
     // method for cube root
                public static void cube_root()
        {
        
         double num, res;
        Console.Write("Enter the Number : ");
        num = double.Parse(Console.ReadLine());
        res = Math.Ceiling(Math.Pow(num, (double)1 / 3));
        Console.Write("Cube Root : " + res);
 
        }
        
                public static void hcf_lcm()
            {

            int n1,n2, temp, hcf, lcm, a, b;
            Console.WriteLine("Enter Two numbers: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            a = n1;
            b = n2;

            while(b!=0)
            {
                temp = b;
                b = a % b;
                a = temp;
            }
            hcf = a;
            lcm = (n1 * n2) / hcf;
            Console.WriteLine("Highest Common Factor =" + hcf);
            Console.WriteLine("Lowest Common Multiples =" + lcm);

            }

                public static void max_min()
                {
                    int n, x, max, min;
                    int[] arr = new int[55];

                    Console.WriteLine("Enter the array size..: ");
                    n = int.Parse(Console.ReadLine());


                   Console.WriteLine("Enter the array elements: ");
                   for(x=0; x<n; x++)
                       {
                            Console.WriteLine("Enter element " + (x + 1) + ": ");

                            arr[x] = int.Parse(Console.ReadLine());
                       }
                        
                        max = arr[0];
                        min = arr[0];

                    for(x=0; x<n; x++)
                       {
                           if(arr[x] > max)
                                {
                                    max = arr[x];
                                }
                            if(arr[x] < min)
                                {
                                   min = arr[x];
                                }
                        }

                        Console.WriteLine("Min value......" + min);
                        Console.WriteLine("Max value......" + max);

                } 
     
     public static void avg()
     {
            int userInput;
		int n, count = 1;
		float x, average, sum = 0;
		Console.WriteLine("Enter the value of n:");
		n = Convert.ToInt32(Console.ReadLine());
		while (count <= n)
		{
			Console.WriteLine("Enter the " + count + " number:");
			userInput = Convert.ToInt32(Console.ReadLine());
			sum += userInput;
			++count;
		}

		average = (float)sum / (n);
		Console.WriteLine("\nThe Average is " + average);
		
	}
	
	public static void exp()
	{
	            double m, n;  
        Console.WriteLine("Enter the Number : ");  
        m = double.Parse(Console.ReadLine());  
        Console.WriteLine("Give the Exponent : ");  
        n = double.Parse(Console.ReadLine());  
        double value1 = Math.Pow(m, n);  
        Console.WriteLine("Result : {0}", value1);  
        Console.ReadLine();  
	}
	
	public static void power()
	{
	    
        int basenumber, exponent,power, i;
 
        // Reading number
        Console.Write("Enter any number: ");
        basenumber = Convert.ToInt32(Console.ReadLine());
 
        Console.Write("Enter any number: ");
        exponent = Convert.ToInt32(Console.ReadLine());
 
        power = 1;
        i = 1;
        //caculatinh power of given number
        while (i <= exponent)
        {
            power = power * basenumber;
            i++;
        }
        Console.Write("Power : "+ power);
 
        Console.ReadLine();
	}

        public static void square()
            {

                Console.WriteLine("Enter a Number : "); 
                int Number = Convert.ToInt16(Console.ReadLine()); 
                double Sqr = Math.Pow(Number,2); 
                Console.WriteLine("Square of {0} is: {1}", Number, Sqr); 
            }

            public static void trig()
            {
        Double angle = Math.PI/4; //45 degrees
        Double value = Math.Sin(angle);
        Console.WriteLine($"Sine ({(180 / Math.PI) * angle} degrees) = {value}");


        Double angle = Math.PI/2; //90 degrees
        Double value = Math.Sin(angle);
        Console.WriteLine($"Sine ({(180 / Math.PI) * angle} degrees) = {value}");

        Double angle = -Math.PI/6; //-60 degrees 
        Double value = Math.Sin(angle);
        Console.WriteLine($"Sine ({(180 / Math.PI) * angle} degrees) = {value}");
        

        Double angle = Math.PI/4; //45 degrees
        Double value = Math.Cos(angle);
        Console.WriteLine($"Cosine ({(180 / Math.PI) * angle} degrees) = {value}");
 

        Double angle = Math.PI/2; //90 degrees 
        Double value = Math.Cos(angle);
        Console.WriteLine($"Cosine ({(180 / Math.PI) * angle} degrees) = {value}");
   
        Double angle = Math.PI/3; //-60 degrees
        Double value = Math.Cos(angle);
        Console.WriteLine($"Cosine ({(180 / Math.PI) * angle} degrees) = {value}");
   

        Double angle = Math.PI/4; //45 degrees
        Double value = Math.Tan(angle);
        Console.WriteLine($"Tangent ({(180 / Math.PI) * angle} degrees) = {value}");    

    
        Double angle = Math.PI/3; //60 degrees 
        Double value = Math.Tan(angle);
        Console.WriteLine($"Tangent ({(180 / Math.PI) * angle} degrees) = {value}");

        Double angle = 0; //0 degrees 
        Double value = Math.Tan(angle);
        Console.WriteLine($"Tangent ({(180 / Math.PI) * angle} degrees) = {value}");

        Double angle = Math.PI/2; //90 degrees 
        Double value = Math.Tan(angle);
        Console.WriteLine($"Tangent ({(180 / Math.PI) * angle} degrees) = {value}");
    
        Double angle = - Math.PI/3; //-60 degrees 
        Double value = Math.Tan(angle);
        Console.WriteLine($"Tangent ({(180 / Math.PI) * angle} degrees) = {value}");
    }
}

}
                
        // main function
        
        public static void Main(string[] args)
        {
 
 // full program execution
            
            
            Console.WriteLine("\t\t\t--- WELCOME TO OUR CALCULAION SYSTEM---\t\t");
            Console.WriteLine("\n Please chooose your operation");
            Console.WriteLine("\n 1. addition");
            Console.WriteLine("\n 2. subtraction");
            Console.WriteLine("\n 3. multiplication");
            Console.WriteLine("\n 4. division");
            Console.WriteLine("\n 5. square root");
            Console.WriteLine("\n 6. square");
            Console.WriteLine("\n 7. cube root");
            Console.WriteLine("\n 8. power");
            Console.WriteLine("\n 9. min value and max value");
            Console.WriteLine("\n 10. lcm and hcf");
            Console.WriteLine("\n 11. average value and max value");
            Console.WriteLine("\n 12. exponential function");
            Console.WriteLine("\n 13. tirgonometry function");
            Console.WriteLine("\n 0. Exit program");
            
            Console.WriteLine("\n Enter your choice of application");
            

            // the switch statements
            
                 int Choice = Convert.ToInt32(Console.ReadLine());
            
                 switch(Choice)
                 {
                
                case 1:
                sum();
                break;

                case 2:
                sub();
                break;

                case 3:
                mul();
                break;
                
                case 4:
                div();
                break;

                case 5:
                sqrt();
                break;

                case 6:
                square();
                break;

                case 7:
                cube_root();
                break;
                
                case 8:
                power();
                break;
                
                case 9:
                max_min();
                break;
                
                case 10:
                hcf_lcm();
                break;
                
                case 11:
                avg();
                break;
                
      
                case 12:
                exp();
                break;

                case 13:
                trig();
                break;
                                
                default:
                Console.WriteLine("Exit program");
                break;
                Console.ReadLine();  
                
              
        
                 }
                
    }

