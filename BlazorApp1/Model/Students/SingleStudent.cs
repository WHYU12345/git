namespace BlazorApp1.Model.Students
{
    public class SingleStudent
    {
        public string Name { get; set; }
        public int Age { get; set; }

        

        public SingleStudent(string name)
        {
            Name = name;
        }

    }
}
