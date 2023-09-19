namespace BasicOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Employee() {Name = "Nisse", Salary = 25000 };
            person.Name = "Kalle";
            person.Do();


            Employee admin = new Admin();
            admin.Do();


            Person admin2 = new Admin();
            Admin admin3 = new Admin();
            //string departmentName = admin3.Department;
            //  var length = departmentName.Length;
            admin3.Do();
            

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

            foreach (var p in persons)
            {
                p.Do();
            }
            
        }


        public static void Do(Person person)
        {
            Console.WriteLine(person);
        }
    }
}