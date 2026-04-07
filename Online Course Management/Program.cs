using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    public class Course
    {
        private string courseId;
        private string title;
        private string instructorName;
        protected double BasePrice;

        public Course(string courseID, string title, string instructorName, double BasePrice)
        {
            this.courseId = courseID;
            this.title = title;
            this.instructorName = instructorName;
            this.BasePrice = BasePrice;
        }

        public virtual void ShowInfoCourse()
        {
            Console.WriteLine("Course ID: " + courseId);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Instructor Name: " + instructorName);
            Console.WriteLine("Base Price: " + BasePrice);
            Console.WriteLine();
        }

        public virtual double CalculateFinalPrice()
        {
            if (BasePrice > 5000)
            {
                Console.WriteLine("Course is premium");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Regular Course");
                Console.WriteLine();
            }

            return BasePrice;
        }

        public bool IsPremium()
        {
            return CalculateFinalPrice() > 5000;
        }
    }

    public class LiveCourse : Course
    {
        private int durationTimeWeeks;
        private int maximumStudent;

        public LiveCourse(string courseId, string title, string instructorName, double BasePrice, int durationTimeWeeks, int maximumStudent)
            : base(courseId, title, instructorName, BasePrice)
        {
            this.durationTimeWeeks = durationTimeWeeks;
            this.maximumStudent = maximumStudent;
        }

        public override void ShowInfoCourse()
        {
            base.ShowInfoCourse();
            Console.WriteLine("Duration Time Weeks: " + durationTimeWeeks);
            Console.WriteLine("Maximum Student: " + maximumStudent);
            Console.WriteLine("Final Price: " + CalculateFinalPrice());
            Console.WriteLine("Premium Course: " + (IsPremium() ? "Yes" : "No"));
            Console.WriteLine();
        }

        public override double CalculateFinalPrice()
        {
            if (durationTimeWeeks > 8)
            {
                return BasePrice + (BasePrice * 0.20);
            }
            else
            {
                return BasePrice;
            }
        }
    }

    public class RecordedCourse : Course
    {
        private double durationTimeHours;
        private bool lifeTimeAccess;

        public RecordedCourse(string courseId, string title, string instructorName, double BasePrice, double durationTimeHours, bool lifeTimeAccess)
            : base(courseId, title, instructorName, BasePrice)
        {
            this.durationTimeHours = durationTimeHours;
            this.lifeTimeAccess = lifeTimeAccess;
        }

        public override void ShowInfoCourse()
        {
            base.ShowInfoCourse();
            Console.WriteLine("Duration Time Hours: " + durationTimeHours);
            Console.WriteLine("Life Time Access: " + lifeTimeAccess);
            Console.WriteLine("Final Price: " + CalculateFinalPrice());
            Console.WriteLine("Premium Course: " + (IsPremium() ? "Yes" : "No"));
        }

        public override double CalculateFinalPrice()
        {
            if (lifeTimeAccess)
            {
                return BasePrice + (BasePrice * 0.10);
            }
            else
            {
                return BasePrice;
            }
        }
    }
    public static class Program
    {
        public static void Main(string[] args)
        {
            LiveCourse live1 = new LiveCourse("101", "Special Problem Solving Class", "Ankur Basak", 6000, 10, 40);
            RecordedCourse rec1 = new RecordedCourse("202", "C# Recorded Masterclass", "Roni", 4800, 25, true);

            live1.ShowInfoCourse();
            rec1.ShowInfoCourse();
        }
    }
}
