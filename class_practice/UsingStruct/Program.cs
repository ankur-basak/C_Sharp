using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using.Struct
{
    public struct Student
    {
        public string name, id;
        public int noc;
        public float cgpa;
        public Student(string n1, string n2, float f1, int c2)
        {
            this.name = n1;
            this.id = n2;
            this.cgpa = f1;
            this.noc = c2;
        }
        public Student(string n)
        {
            this.name = n;
            this.id = n;
            this.cgpa = 0.0f;
            this.noc = 0;
        }
        public void print()
        {
            Console.WriteLine(name + " " + id + " " + cgpa);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] array = new Student[10];
            array[0].id = "21-1111-1";
            array[0].name = "Zareef";
            array[0].cgpa = 4.0f;
            array[0].noc = 100;
            array[0].print();
            
            int[][] jarray = new int[4][];
            jarray[0] = new int[3] {10,20,30};
            jarray[1] = new int[2] { 45, 67 };
            jarray[2] = new int[5] { 7, 8, 91, 33, 23 };
            jarray[3] = new int[4] { 1, 2, 3, 4 };
            foreach (int[] r in jarray)
            { 
                foreach(int c in r)
                {
                    Console.Write(c+" ");
                }
                Console.WriteLine();
            }
            
            int[,] a = new int[2,3];
            int[,] b = new int[,] { { 23, 77 }, { 10, 32 }, { 81, 30 } };

            XOXOXO;
            OXOXOX;
            XOXOXO;
            OXOXOX;
            
            int[] arr = new int[] { 1, 2, 3, 4 };
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(i);
            }
            
            int i = 11;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 10);
            
            while(i<=10)
            {
                Console.WriteLine(i);
                i++;
            }
            
            int i1 = Convert.ToInt32(Console.ReadLine());
            int i2 = Convert.ToInt32(Console.ReadLine());
            char c= Convert.ToChar(Console.ReadLine());
            switch(c)
            {
                case '+':
                    Console.WriteLine(i1 + i2);
                    break;
                case '-':
                    Console.WriteLine(i1 - i2);
                    break;
                case '*':
                    Console.WriteLine(i1 * i2);
                    break;
                case '/':
                    Console.WriteLine(i1 / i2);
                    break;
                default:
                    Console.WriteLine("invalid operator");
                    break;
            }
            
            if (c == '+')
            {
                Console.WriteLine(i1 + i2);
            }
            else if (c == '-')
            {
                Console.WriteLine(i1 - i2);
            }
            else if (c == '*')
            { 
                Console.WriteLine(i1 * i2); 
            }
            else if (c == '/')
            { 
                Console.WriteLine(i1 / i2); 
            }
            else
            { 
               Console.WriteLine("invalid operator");
            }
            
            //3 inputs,2 integers and 1 char
            int i=Convert.ToInt32(Console.ReadLine());
            float f=Convert.ToSingle(Console.ReadLine());
            char c=Convert.ToChar(Console.ReadLine());

            if (i % 2 == 0)
            {
                i = i + 10;
                Console.WriteLine(i);
            }
            else if(i==0)
            {
                Console.WriteLine(i);
            }    
            else
            {
                i = i - 10;
                Console.WriteLine(i);
            }
           
            int x = 10,y=20;
            Console.Write("The addition of x+y:{0}",x+y);
            Console.WriteLine("The value of x:{0} and y:{1}",x,y);
            Console.WriteLine("The value of x:"+x+" and y:"+y);//concentation
            
        }
    }
}
