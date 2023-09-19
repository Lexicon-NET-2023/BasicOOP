namespace BasicOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Employee() {Name = "Nisse", Salary = 25000 };
            person.Name = "Kalle";


            Employee admin = new Admin();
            Person admin2 = new Admin();
            Admin admin3 = new Admin();
            string departmentName = admin3.Department;
            var length = departmentName.Length;
            

            Do(admin3);
            Do(admin2);
            Do(admin);

            var persons = new List<IPerson>()
            {
                person,
                admin2,
                admin3,
                admin
            };
            
        }


        public static void Do(Person person)
        {
            Console.WriteLine(person);
        }
    }
}