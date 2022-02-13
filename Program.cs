using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQlekcija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IList<Student> studentList = new List<Student>() {
            //    new Student() { Id = 1, Name = "John", Age = 13} ,
            //    new Student() { Id = 2, Name = "Moin", Age = 21 } ,
            //    new Student() { Id = 3, Name = "Bill", Age = 18 } ,
            //    new Student() { Id = 4, Name = "Ram" , Age = 20} ,
            //    new Student() { Id = 5, Name = "Ron" , Age = 15 } ,
            //    new Student() { Id = 6, Name = "Idk" , Age = 18} ,
            //    new Student() { Id = 7, Name = "Yah" , Age = 18} ,
            //    new Student() { Id = 8, Name = "Ik" , Age = 20} ,};

            //var selectResult1 = from s in studentList select s.Name; // collection of string
            //var selectResult2 = studentList.Select(s => s.Name );

            //foreach (var studentName in selectResult1)
            //{
            //    Console.WriteLine(studentName);
            //}

            //Console.WriteLine("");

            //foreach (var studentName in selectResult2)
            //{
            //    Console.WriteLine(studentName);
            //}

            //Console.ReadLine();

            //var filteredResult1 = from student in studentList
            //                     where student.Age >=  18
            //                     select student.Name;

            //var filteredResult2 = studentList.Where(student => student.Age >= 18).Select(student => student.Name);

            //foreach (var studentName in filteredResult1)
            //{
            //    Console.WriteLine(studentName);
            //}

            //Console.WriteLine("");

            //foreach (var studentName in filteredResult2)
            //{
            //    Console.WriteLine(studentName);
            //}

            //var orderByResult = from student in studentList
            //                    orderby student.Age ascending
            //                    select  new { student.Name, student.Age};

            //var orderByAscendingResult = 
            //    studentList.OrderBy(student => student.Age)
            //    .Select(student => new { student.Name, student.Age });

            //foreach (var student in orderByResult)
            //{
            //    Console.WriteLine(student);
            //}

            //Console.WriteLine("");

            //foreach (var student in orderByAscendingResult)
            //{
            //    Console.WriteLine(student);
            //}

            //Console.WriteLine("");

        //// ThenBy HW

            //var groupedResult1 = from student in studentList
            //                     orderby student.Age ascending
            //                     group student by student.Age;

            ////iterate each group 
            //foreach (var ageGroup in groupedResult1)
            //{
            //    Console.WriteLine("Age Group: {0}", ageGroup.Key);

            //    //Each group has a key 
            //    foreach (Student student in ageGroup) // Each group has inner collection 
            //        Console.WriteLine("Student Name: {0}", student.Name);
            //}

            //Console.WriteLine("");

            //var groupedResult2 = 
            //    studentList.OrderBy(student => student.Age).GroupBy(student => student.Age);

            //foreach (var ageGroup in groupedResult2)
            //{
            //    Console.WriteLine("Age Group: {0}", ageGroup.Key);

            //    //Each group has a key 
            //    foreach (Student student in ageGroup) // Each group has inner collection 
            //        Console.WriteLine("Student Name: {0}", student.Name);
            //}
            IList<Student> studentList = new List<Student>() {
                new Student() { Id = 1, Name = "John", Age = 13, StandardID =1 },
                new Student() { Id = 2, Name = "Moin", Age = 21, StandardID =1 },
                new Student() { Id = 3, Name = "Bill", Age = 18, StandardID =2 },
                new Student() { Id = 4, Name = "Ram" , Age = 20, StandardID =2 },
                new Student() { Id = 5, Name = "Ron" , Age = 15, StandardID =3 },
                new Student() { Id = 6, Name = "Albina" , Age = 15, StandardID =3 },
                new Student() { Id = 7, Name = "Sabina" , Age = 18, StandardID =1 }};

            IList<Standard> standardList = new List<Standard>() {
                new Standard(){ StandardID = 1, StandardName="Standard 1"},
                new Standard(){ StandardID = 2, StandardName="Standard 2"},
                new Standard(){ StandardID = 3, StandardName="Standard 3"} };

            //var innerJoin1 = from student in studentList // outer sequence 
            //                join standard in standardList //inner sequence 
            //                on student.StandardID equals standard.StandardID // key selector 
            //                select new
            //                { // result selector 
            //                    StudentName = student.Name,
            //                    StandardName = standard.StandardName
            //                };

            //foreach (var inner in innerJoin1)
            //{
            //    Console.WriteLine(inner);
            //} ;

            //Console.WriteLine();

            //var innerJoin2 =
            //    studentList.Join(standardList,
            //        studentItem => studentItem.StandardID,
            //        standart => standart.StandardID,
            //        (studentItem, standart) => new
            //            {
            //                StudentName = studentItem.Name,
            //                StandardName = standart.StandardName
            //            }
            //        );

            //foreach (var inner in innerJoin2)
            //{
            //    Console.WriteLine(inner);
            //};
            //Console.WriteLine();

            //bool areAllStudentsTeenAger = studentList.All(student => student.Age > 18); 
            //Console.WriteLine(areAllStudentsTeenAger);

            //bool isAnyStudentTeenAger = studentList.Any(student => student.Age > 18); 
            //Console.WriteLine(isAnyStudentTeenAger);

            //Console.WriteLine();

            //IList<int> intList = new List<int>() { 1, 2, 3, 4, 5 };
            //bool result1 = intList.Contains(10); // returns false
            //Console.WriteLine(result1);

            Student student = new Student() { Id = 1, Name = "John", Age = 13, StandardID = 1 };

            //bool result2 = studentList.Contains(student); //returns false
            //Console.WriteLine(result2);

            bool result3 = studentList.Contains(student, new StudentComparer());
            Console.WriteLine(result3);

            bool result4 = studentList.Contains(student, new CompareStudents(student.Name,student.Id));
            Console.WriteLine(result4);

            //var adultStudents = studentList.Count(s => s.Age >= 18);
            //Console.WriteLine("Number of Adult Students: {0}", adultStudents);

            //var oldest = studentList.Max(student => student.Age);
            //Console.WriteLine("Oldest Student Age: {0}", oldest);

            //var sumOfAges = studentList.Sum(student =>
            //    {
            //        if (student.Age >= 18)
            //        {
            //            return student.Age;
            //        }
            //        else
            //        {
            //            return 0;
            //        }
            //    }
            //);
            //Console.WriteLine("Combination of ages who are >=18: {0}", sumOfAges);

            //Console.WriteLine("1st Element in intList: {0}", studentList.First().Name);

            //Console.WriteLine("1st Even Element in intList: {0}", studentList.First(student => student.Age == 15).Name);
            //Console.ReadKey();

            //Console.WriteLine("The only element which is less than 10 in intList: {0}", studentList.FirstOrDefault(student => student.Age == 100));
        }
    }
}