using System;

namespace MongoDBDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoCRUD db = new MongoCRUD("AddressBook");

            //PersonModel person = new PersonModel
            //{
            //    FirstName = "Jhon",
            //    LastName = "Smith",
            //    PrimaryAddress=new AddressModel
            //    {
            //        StreetAddress="101 Oak street",
            //        City="Stramton",
            //        State="PA",
            //        ZipCode="18512"
            //    }
            //};


            //db.InsertRecord("Users",person);

            var recs = db.LoadRecords<NameModel>("Users");
            foreach (var rec in recs)
            {
                Console.WriteLine($" {rec.FirstName} {rec.LastName}");
                Console.WriteLine();
            }

            //foreach (var rec in recs)
            //{
            //    Console.WriteLine($"{rec.Id}: {rec.FirstName} {rec.LastName}");
            //    if (rec.PrimaryAddress != null)
            //    {
            //        Console.WriteLine(rec.PrimaryAddress.City);
            //    }
            //    Console.WriteLine();
            //}
            // var oneRec= db.LoadRecordById<PersonModel>("Users", new Guid("a6182093-49ec-433b-81da-aa1ff03f8f89"));
            // oneRec.DateOfBirth = new DateTime(1982, 10, 31, 0, 0, 0, DateTimeKind.Utc);
            // db.UpsertRecord("Users", oneRec.Id, oneRec);
            // db.DeleteRecord<PersonModel>("Users", oneRec.Id);
            Console.WriteLine("Hello World");
        }
    }
}
