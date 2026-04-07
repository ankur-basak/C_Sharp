using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Course{

    int courseId;
    string title;
    int[][] scores;
    public Course(){

        courseId = 0;
        title = "Undefined";
        scores = new int[3][];
        scores[0] = new int[] { 10, 20 };
        scores[1] = new int[] { 30, 40, 50 };
        scores[2] = new int[] { 60 };
    }
    public Course(int id) : this()
    {
        courseId = id;
    }
    internal Course(int id, string t) : this(id)
    {
        title = t;
    }
    internal Course(int id, string t, int size) : this(id, t){

        scores = new int[size][];

        for (int i = 0; i < size; i++)
        {
            scores[i] = new int[i + 2];

            for (int j = 0; j < scores[i].Length; j++)
            {
                scores[i][j] = (i + 1) * (j + 1) * 5;
            }
        }
    }
    public void Display()
    {
        Console.WriteLine(courseId + " " + title);

        for (int i = 0; i < scores.Length; i++)
        {
            for (int j = 0; j < scores[i].Length; j++)
            {
                Console.Write(scores[i][j] + " ");
            }

            Console.WriteLine();
        }
    }
}
class Program{
    static void Main()
    {
        Course c = new Course(202, "Programming", 4);
        c.Display();
    }
}