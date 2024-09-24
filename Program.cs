namespace In_Class_OOP_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            School school = new School("USF Elementary", "Mr. Sathe", 500);
            Console.WriteLine("School Info:");
            school.DisplayInfo();
            Console.WriteLine();

            MiddleSchool middleSchool = new MiddleSchool("USF Middle School", "Mr. Tejas", 800, 6, 8);
            Console.WriteLine("Middle School Info:");
            middleSchool.DisplayInfo();
            Console.WriteLine();

            HighSchool highSchool = new HighSchool("USF Bull High School", "Dr. Manish", 1200, "Yuengling Center");
            Console.WriteLine("High School Info:");
            highSchool.DisplayInfo();
            Console.WriteLine();
        }
    }
}
