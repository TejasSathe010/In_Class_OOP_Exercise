namespace In_Class_OOP_Exercise
{
    public class School
    {
        public string? Name { get; set; }
        public string? PrincipalName { get; set; }
        public int StudentCount { get; set; }

        public School(string name, string principalName, int studentCount)
        {
            Name = name;
            PrincipalName = principalName;
            StudentCount = studentCount;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"School Name: {Name}");
            Console.WriteLine($"Principal Name: {PrincipalName}");
            Console.WriteLine($"Student Count: {StudentCount}");
        }
    }
}
