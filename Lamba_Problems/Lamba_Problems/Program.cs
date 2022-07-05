

namespace Lamba_Problems
{

    internal class Program
    {
        public static void Main(String[] args)
        {    //UC1
            List<Person> listpersonincity = new List<Person>();
            listpersonincity.Add(new Person("4745424", "John", "12 main streat Newyork YK", 15));
            listpersonincity.Add(new Person("35444442", "Aamir", "14 main streat UK YK", 50));
            listpersonincity.Add(new Person("23403444", "Shahrukh", "17 main streat Mumbai YK", 56));
            listpersonincity.Add(new Person("76888786", "Salman", "19 main streat Delhi YK", 70));
            listpersonincity.Add(new Person("27687786", "Amresh", "13 main streat Assam YK", 53));
            listpersonincity.Add(new Person("27867667", "Johnny", "15 main streat Madras YK", 62));
            listpersonincity.Add(new Person("27687786", "Hritik", "20 main streat chennai YK", 45));
            listpersonincity.Add(new Person("27867667", "Amitabh", "22 main streat Kolkata YK", 72));

            //UC2
            Console.WriteLine("\n______________________________________");
            Console.WriteLine("Retriving top 2 aged persons from the list who are below 60 years");
            foreach (Person person in listpersonincity.FindAll(e => (e.Age <= 60)).Take(2).ToList())
            {
                Console.WriteLine("Name:" + person.Name + "\t\tAge:" + person.Age);
            }

        }
    }
}