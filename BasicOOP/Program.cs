namespace BasicOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name = "Kalle";
            var res = name.AddString("Anka");
            Console.WriteLine(res);

            //FirstPart();
            var v = new Vehicle("Volvo");
            var c = new Car("Volvo", "740");
            Console.WriteLine(c.Drive(20));

            IDrivable audi = new Audi();

            var vehicles = new List<IDrivable>();
            vehicles.Add(v);
            vehicles.Add(c);
            vehicles.Add(audi);

            foreach (IDrivable vehicle in vehicles)
            {
                Console.WriteLine(vehicle.Drive(50));

                //Audi audi2 = (Audi)vehicle;

                //Audi audi3 = vehicle as Audi;
                //Console.WriteLine(audi3.AudiSpecialMethod());

                //Audi audi3 = vehicle as Audi;

                //if(audi3 != null)
                //{
                //   Console.WriteLine(audi3.AudiSpecialMethod());
                //}

                //if(vehicle is Audi)
                //{
                //    Audi audi2 = (Audi)vehicle;
                //    audi2.AudiSpecialMethod();

                //} 
                
                if(vehicle is Audi castedToAudi)
                {
                    castedToAudi.AudiSpecialMethod();
                }

            }

        }

        private static void FirstPart()
        {
            Person person = new Employee() { Name = "Nisse", Salary = 25000 };
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