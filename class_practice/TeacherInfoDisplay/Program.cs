using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teacher
{
    public string name;
    public int id;
    public float salary;

    public teacher()
    {
        name = " ";
        id = 0;
        salary = 0.0f;
    }

    public Teacher(string name, int id , float salary)
    {
        this.name = name;
        this,id = id;
        this.salary = salary;
    }

    publio0c void display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Salary: " + salary);
    }

    public void calculationBonus()
    {
        if (salary > 50000)
        {
           float bonus = salary * 0.50;
        }
        else
        {
            float bonous = salary * 0.25;
        }
        Console.WriteLine("Bonus: " + bonus);
        Console.WriteLine("Total Salary: " + (salary + bonus));
    }
}

class Main
{
    static void Main(string[] args)
    {
        Teacher teacher1 = new Teacher;

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your salary: ");
            float salary = Convert.ToSingle(Console.ReadLine());

            teacher[i] = new Teacher(name, id, salary);
        }
        Console.WriteLine("Total salary with bonus: ");

        for(int i = 0; i<4; i++)
        {
            teacher.display();
            teacher.calculationBonus();
        }
    }   
    Console.ReadLine();
}
