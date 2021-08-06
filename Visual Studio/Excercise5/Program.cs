using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise5
{
    /*	1. Define a class Student, which contains the following information about students: 
        full name, course, subject, university, e-mail and phone number.*/
    public class Student
    {
        public string fullName;
        public string course;
        public string subject;
        public string university;
        public string email;
        public string phoneNumber;
        /*3. Add a static field for the class Student, which holds the number of created objects of this class.*/
        static int countObjects = 0;

        /*2. Declare several constructors for the class Student, which have different lists of parameters 
            (for complete information about a student or part of it). Data, which has no initial value to be 
            initialized with null. Use nullable types for all non-mandatory data.*/
        public Student(string fullName)
        {
            this.fullName = fullName;
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
        }

        /*4. Add a method in the class Student, which displays complete information about the student.*/
        public void PrintStudent()
        {
            Console.WriteLine("Full Name: {0}, Course: {1}, Subject: {2}, University {3}, E-mail {4}, Phone Number: {5}",
            this.fullName, this.course, this.subject, this.university, this.email, this.phoneNumber);
        }

        /*5. Modify the current source code of Student class so as to encapsulate the fields in the class using properties.*/
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
    public class StudentTest
    {
        public void CreatedStudent()
        {
            Student student1 = new Student("JD2", "WP", "C#", "ISI", "jhon2@gmail.com", "514346-2");
            student1.PrintStudent();
            Student student2 = new Student("JD3", "WP", "C#", "ISI", "jhon3@gmail.com", "514346-3");
            student2.PrintStudent();
        }
    }

    namespace BookLibrary
    {
        class program
        {
            public static void Question1()
            /*1. There is a book library. Define classes respectively for a book and a library. The library must contain a name and a 
             * list of books (You can use an array). The books must contain the title, author, publisher, release date and ISBN-number. 
             * In the class, which describes the library, create methods to add a book to the library, to search for a book 
             * by a predefined author, to display information about a book and to delete a book from the library.*/
            {

            }
            public static void Question2()
            /* 2. Write a test class, which creates an object of type library, adds several books to it and displays information 
             * about each of them. Implement a test functionality, which finds all books authored by Stephen King and deletes them. 
             * Finally, display information for each of the remaining books.*/
            {

            }
        }

    }
    namespace PartialClass
    {
        class program
        {
            public static void Question1()
            /*1. Create a class Employee.*/
            {

            }
            public static void Question2()
            /*2. Split the class definition into 2 different files.*/
            {

            }
            public static void Question3()
            /*3. Add some auto-implemented properties (Id, FirstName, LastName, Birthday, SocialInsuranceNum) in one source file.*/
            {

            }
            public static void Question4()
            /*4. Add some public methods in the second file. For example, a method Display to print complete information about the Employee.*/
            {

            }
            public static void Question5()
            /*5. Write a class EmployeeTest, which has to test the functionality of the class Employee.*/
            {

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("JD", "WP", "C#", "ISI", "jhon@gmail.com", "514346-1");
            student1.PrintStudent();
            StudentTest stu = new StudentTest();
            stu.CreatedStudent();

            Console.ReadLine();
        }
    }
}
