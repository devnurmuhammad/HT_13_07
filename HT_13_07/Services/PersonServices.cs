using HT_13_07.Data;
using HT_13_07.Models;


namespace HT_13_07.Services
{
    public class PersonServices : HT_13_DB
    {
        
        public void AddPerson(string firstname, string lastname)
        {
            using (HT_13_DB db = new HT_13_DB())
            {
                Person person = new Person();

                person.FirstName = firstname;
                person.LastName = lastname;

                db.Add(person);
                db.SaveChanges();
            }
        }

        public void UpdatePerson(int id, string newlastname, string newfirstname) 
        { 
            using (HT_13_DB db = new HT_13_DB()) 
            {
                Person person = new Person();
                var result = db.Persons.ToList().FirstOrDefault(person => person.Id == id);
                if (result != null)
                {
                    result.FirstName = newfirstname;
                    result.LastName = newlastname;
                }
                else
                {
                    Console.WriteLine("Bunday Id li foydalanuvchi topilmadi!");
                }
                db.Update(person);
                db.SaveChanges();
            }
        }
        
        public void DeletePerson(int id)
        {
            using (HT_13_DB db = new HT_13_DB())
            {
                Person person = new Person();
                var result = db.Persons.ToList().FirstOrDefault(person => person.Id == id);
                if (result != null)
                {
                    db.Persons.Remove(result);
                    db.SaveChanges();
                }
            }
        }

        public void GetPerson(int id)
        {
            using (HT_13_DB db = new HT_13_DB())
            {
                Person person = new Person();
                var result = db.Persons.FirstOrDefault(person => person.Id == id);
                if (result != null)
                {
                    Console.WriteLine($"Ism: {result.FirstName} Familiya: {result.LastName}");
                }
            }
        }
    }
}
