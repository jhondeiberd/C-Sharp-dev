﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise5
{
    namespace StudentClass
    {
        /*	1. Define a class Student, which contains the following information about students: 
            full name, course, subject, university, e-mail and phone number.*/
        public class Student
        {
            //Fields
            private string fullName;
            private string course;
            private string subject;
            private string university;
            private string email;
            private string phoneNumber;
            /*3. Add a static field for the class Student, which holds the number of created objects of this class.*/
            private static int countStudents = 0;

            /*2. Declare several constructors for the class Student, which have different lists of parameters 
                (for complete information about a student or part of it). Data, which has no initial value to be 
                initialized with null. Use nullable types for all non-mandatory data.*/
            public Student(string fullName)
            {
                this.fullName = fullName;
            }


            /*3. Add a static field for the class Student, which holds the number of created objects of this class.*/
            public int GetNumberStudents()
            {
                return Student.countStudents++;
            }

            public Student(string fullName, string course)
            {
                this.fullName = fullName;
                this.course = course;
            }

            public Student(string fullName, string course, string subject, string university, string email, string phoneNumber)
            {
                this.fullName = fullName;
                this.course = course;
                this.subject = subject;
                this.university = university;
                this.email = email;
                this.phoneNumber = phoneNumber;
                Student.countStudents++;
            }

            /*4. Add a method in the class Student, which displays complete information about the student.*/
            public void PrintStudent()
            {
                Console.WriteLine("Full Name: {0}, Course: {1}, Subject: {2}, University {3}, E-mail {4}, Phone Number: {5}",
                this.fullName, this.course, this.subject, this.university, this.email, this.phoneNumber);
            }

            /*5. Modify the current source code of Student class so as to encapsulate the fields in the class using properties.*/

            //Properties
            public string FullName { get; set; }
            public string Course { get; set; }
            public string Subject { get; set; }
            public string University { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
        }
        /*6. Write a class StudentTest, which has to test the functionality of the class Student. 
        Add a static method in class StudentTest, which creates several objects of type Student and store them in static fields. 
        Create a static property of the class to access them. Write a test program, 
        which displays the information about them in the console.*/
        class StudentTest
        {
            static Student[] students = new Student[3];
            public static void CreatedStudent()
            {
                students[0] = new Student("JD2", "WP", "C#", "ISI", "jhon2@gmail.com", "514346-2");
                students[1] = new Student("JD3", "WP", "C#", "ISI", "jhon3@gmail.com", "514346-3");
                students[2] = new Student("JD4", "WP", "C#", "ISI", "jhon4@gmail.com", "514346-5");
            }
        }
    }

    namespace BookLibrary
    {
        class Library
        {
            public string Name { get; set; }
            List<Book> books = new List<Book>();

            public void AddBook(string title, string author, string publisher, DateTime releaseDate, string isbnNumber)
            {
                books.Add(new Book(title, author, publisher, releaseDate, isbnNumber));
            }

            public int SearchBook(string author)
            {
                for (int i = 0; i < books.Count; i++)
                {
                    if (books[i].Author == author)
                        return i;
                }

                return -1;
            }

            public void DeleteBook(int i)
            {
                if (i >= 0)
                    books.RemoveAt(i);
            }

            public void PrintBooks()
            {
                Console.WriteLine("\nThese are the books at the Library:");
                foreach (Book b in books)
                {
                    Console.WriteLine(b);
                }
            }
        }

        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public DateTime ReleaseDate { get; set; }
            public string ISBNNumber { get; set; }

            public Book(string title, string author, string publisher, DateTime releaseDate, string isbnNumber)
            {
                Title = title;
                Author = author;
                Publisher = publisher;
                ReleaseDate = releaseDate;
                ISBNNumber = isbnNumber;
            }
            public override string ToString()
            {
                return "\nTitle: " + Title + "\nAuthor: " + Author + "\nPublisher: " + Publisher + "\nRelease Date: " + ReleaseDate + "\nISBN Number: " + ISBNNumber;
            }
        }
    }

    namespace PartialClass
    {
        partial class Employee
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime Birthday { get; set; }
            public int SocialInsuranceNum { get; set; }
        }

        partial class Employee
        {
            public void PrintEmployed()
            {
                Console.WriteLine("\nID Employee: {0}\n Fisrtname employee: {1}\n Lastname employee: {2}\n SIN: {3}\n", 
                    ID, FirstName, LastName, SocialInsuranceNum);
            }
        }
    }

    class Program
    {
        static void BookTest()
        {
            BookLibrary.Library library = new BookLibrary.Library();
            library.AddBook("Book1", "Stephen King", "TestPublisher1", DateTime.Now, "bk0001");
            library.AddBook("Book2", "AuthorBook", "TestPublisher2", DateTime.Now, "bk0002");
            library.PrintBooks();
            library.DeleteBook(library.SearchBook("Stephen King"));
            library.PrintBooks();
        }

        static void EmployeeTest()
        {
            PartialClass.Employee employee1 = new PartialClass.Employee() 
            { ID = 1, LastName = "Diaz", FirstName = "Jhon", SocialInsuranceNum = 999888452 };
            employee1.PrintEmployed();
            PartialClass.Employee employee2 = new PartialClass.Employee()
            { ID = 2, LastName = "Diaz Parra", FirstName = "Jhon Deiber", SocialInsuranceNum = 999888453 };
            employee2.PrintEmployed();
        }

        static void Main(string[] args)
        {
            StudentClass.Student student1 = new StudentClass.Student("JD", "WP", "C#", "ISI", "jhon@gmail.com", "514346-1");
            student1.PrintStudent();
            StudentClass.StudentTest.CreatedStudent();
            Console.WriteLine("No. of students = {0}", student1.GetNumberStudents());
            Console.ReadLine();

            Console.WriteLine("BOOK'S INFORMATION");
            BookTest();
            Console.ReadLine();

            Console.WriteLine("EMPLOYEE INFORMATION");
            EmployeeTest();
            Console.ReadLine();


        }
    }
}
