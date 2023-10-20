namespace ReflectionException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student student = new Student();
                student.Name = "personname";
                student.Surname = "personsurname";
                student.ShowInfo();

                Teacher teacher = new Teacher(); 

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}