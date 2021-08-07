using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises6
{

    public class School
    {
        private List<Classes> Classes;
    }

    public class People
    {
        private int lastName;
        private int firstName;

        public int FirstName
        {
            get => default;
            set
            {
            }
        }

        public int LastName
        {
            get => default;
            set
            {
            }
        }
    }

    public class Student1 : People
    {
        private int idStudent;

        public int IdStudent
        {
            get => default;
            set
            {
            }
        }
    }

    public class Teacher : People
    {
    }

    public class Classes
    {
        private int idClass;


        public int IdClass
        {
            get => default;
            set
            {
            }
        }
    }

    public class Course
    {
        private int name;
        private int numberClass;
        private int numberExcercise;

        public int Name
        {
            get => default;
            set
            {
            }
        }

        public int NumberClass
        {
            get => default;
            set
            {
            }
        }

        public int NumberExcercise
        {
            get => default;
            set
            {
            }
        }
    }
    class diagram
    {

    }
}
