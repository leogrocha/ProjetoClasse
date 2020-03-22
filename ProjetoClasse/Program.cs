using System;
using System.Globalization;

namespace ProjetoClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Nota student1, student2;

            student1 = new Nota();
            student2 = new Nota();

            Console.WriteLine("Student data 1");
            Console.Write("Name: ");
            student1.Name = Console.ReadLine();
            Console.Write("Note 1: ");
            student1.Note1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Note 2: ");
            student1.Note2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Note 3: ");
            student1.Note3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Note 4: ");
            student1.Note4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("Student data 2");
            Console.Write("Name: ");
            student2.Name = Console.ReadLine();
            Console.Write("Note 1: ");
            student2.Note1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Note 2: ");
            student2.Note2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Note 3: ");
            student2.Note3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Note 4: ");
            student2.Note4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            double avgStudent1 = (student1.Note1 + student1.Note2 + student1.Note3 + student1.Note4) / 4.00;
            Console.WriteLine("Media student 1: " + avgStudent1.ToString("F2", CultureInfo.InvariantCulture));

            double avgStudent2 = (student2.Note1 + student2.Note2 + student2.Note3 + student2.Note4) / 4.00;
            Console.WriteLine("Media student 2: " + avgStudent2.ToString("F2", CultureInfo.InvariantCulture));

            if (avgStudent1 > avgStudent2)
                Console.WriteLine("Student 1 has higher average: " + avgStudent1.ToString("F2", CultureInfo.InvariantCulture));
            else if (avgStudent2 > avgStudent1)
                Console.WriteLine("Student 2 has higher average: " + avgStudent2.ToString("F2", CultureInfo.InvariantCulture));
            else
                Console.WriteLine("Equal average");


        }
    }
}
