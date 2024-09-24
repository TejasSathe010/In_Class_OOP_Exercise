namespace In_Class_OOP_Exercise
{
    public class MiddleSchool : School
    {
        public int LowestGrade { get; set; }
        public int HighestGrade { get; set; }

        public MiddleSchool(string name, string principalName, int studentCount, int lowestGrade, int highestGrade)
            : base(name, principalName, studentCount)
        {
            LowestGrade = lowestGrade;
            HighestGrade = highestGrade;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Lowest Grade: {LowestGrade}");
            Console.WriteLine($"Highest Grade: {HighestGrade}");
        }
    }
}
