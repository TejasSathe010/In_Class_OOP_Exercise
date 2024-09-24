namespace In_Class_OOP_Exercise
{
    public class HighSchool : School
    {
        public string? SportsFieldName { get; set; }

        public HighSchool(string name, string principalName, int studentCount, string sportsFieldName)
            : base(name, principalName, studentCount)
        {
            SportsFieldName = sportsFieldName;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Sports Field Name: {SportsFieldName}");
        }
    }
}
