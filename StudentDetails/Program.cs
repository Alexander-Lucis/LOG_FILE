using System;
namespace StudentDetails
{
    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public float Marks1 { get; set; }
        public float Marks2 { get; set; }
        public float Marks3 { get; set; }

        public void AcceptDetails()
        {
            RollNo = GetValidInteger("Enter Student Roll No:");
            Console.WriteLine("Enter Student Name:");
            Name = Console.ReadLine();

            Marks1 = GetValidFloat("Enter Marks in Subject 1:");
            Marks2 = GetValidFloat("Enter Marks in Subject 2:");
            Marks3 = GetValidFloat("Enter Marks in Subject 3:");
        }
        private int GetValidInteger(string prompt)
        {
            int validInput;
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out validInput))
                {
                    return validInput;
                }
                else
                {
                    Console.WriteLine("ERROR! Please enter a valid number.");
                }
            }
        }
        private float GetValidFloat(string prompt)
        {
            float validInput;
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                if (float.TryParse(input, out validInput))
                {
                    return validInput;
                }
                else
                {
                    Console.WriteLine("ERROR! Please enter a valid number.");
                }
            }
        }
        public float CalculatePercentage()
        {
            float totalMarks = Marks1 + Marks2 + Marks3;
            float percentage = (totalMarks / 300) * 100;
            return percentage;
        }
        public void DisplayDetails()
        {
            float percentage = CalculatePercentage();
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine($"Roll No: {RollNo}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Marks in Subject 1: {Marks1}");
            Console.WriteLine($"Marks in Subject 2: {Marks2}");
            Console.WriteLine($"Marks in Subject 3: {Marks3}");
            Console.WriteLine($"Percentage: {percentage:F2}%");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = GetValidInteger("Enter the number of students:");

            Student[] students = new Student[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nEntering details for Student {i + 1}:");
                students[i] = new Student();
                students[i].AcceptDetails();
            }
            Console.WriteLine("\nDisplaying Student Details with Percentages:");
            foreach (var student in students)
            {
                student.DisplayDetails();
            }

            Console.ReadLine();
        }
        private static int GetValidInteger(string prompt)
        {
            int validInput;
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out validInput))
                {
                    return validInput;
                }
                else
                {
                    Console.WriteLine("ERROR! Please enter a valid number.");
                }
            }
        }
    }
}
