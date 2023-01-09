using System;
using System.Collections.Generic;

namespace CarLot
{
     class Program
    {
        static void Main(string[] args)
        {
                var students = new List<string>()
                {
                    "dek", "haji", "xashi",
                    "ahmed", "axmed", "canab"
                };
               // students.ForEach(singleStudent => Console.WriteLine($"student names is : {singleStudent}"));
                students.Add("cali");
               // students.ForEach(singleStudent => Console.WriteLine($"after i added cali : {singleStudent}"));

                var teachers = new List<string> ()
                {
                    "adam", "heather", "Jissie"
                };
               // teachers.ForEach(oneTeacher => Console.WriteLine($"teachers  : {oneTeacher}"));
                teachers.Add("ahmed");
                //teachers.ForEach(oneTeacher => Console.WriteLine($"teachers  : {oneTeacher}"));
                teachers.Remove("ahmed");
                // teachers.ForEach(oneTeacher => Console.WriteLine($"after the remove  : {oneTeacher}"));

                teachers.AddRange(students);
                //teachers.ForEach(oneTeacher => Console.WriteLine($"after adding another list  : {oneTeacher}"));

                string myName = teachers.Find(student => student.StartsWith("d"));
                //Console.WriteLine($"yoow i found my {myName}");

                var shortNames = teachers.Find(teacher => teacher.Length == 3);
                //Console.WriteLine(shortNames);

            var mercedes = new Dictionary<string, string>()
            {
                {"Year", "1914"},
                {"Make", "mercedes"},
                {"Model", "Benz"},
                {"Price", "30000"}
            };
            Dictionary<string, string> tesla = new Dictionary<string, string>()
            {
                {"Year", "2017"},
                {"Make", "Tesla"},
                {"Model", "X"},
                {"Price", "80000.45"}
            };
            Console.WriteLine(mercedes["Year"]);



            //with class
            var toyota = new Car();
            toyota.Year = 2018;
            toyota.Make = "Toyota";
            toyota.Model = "Camry";
            toyota.Price = 25440;

            //var Garage = List<Dictionary< car>>();
//use dot notation to console log the class.
             Console.WriteLine(toyota.Model);


        }

        // private static object List<T>()
        // {
        //     throw new NotImplementedException();
        // }
    }
}
