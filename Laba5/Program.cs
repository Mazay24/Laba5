using readers;
using students;
using System;

namespace Laba5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[3];
            Reader[] readers = new Reader[3];

            students[0] = new Student("Иванов И. И.", 142141, 17);
            students[1] = new Student("Чуйкина Л.А.", 64565, 19);
            students[2] = new Student("Егоров З.И", 5615, 15);

            readers[0] = new Reader("Кузнецов П. И.", 120, "Физкультурный", new DateTime(2000, 3, 24), "89991102424");
            readers[1] = new Reader("Стрельцов Р. Ф.", 145, "Журналистика", new DateTime(2005, 3, 12), "89054054942");
            readers[2] = new Reader("Милов А. Д.", 120, "Исторический", new DateTime(2005, 6, 4), "89374108172");

            foreach (var student in students)
            {
                student.printData();
            }

            foreach (var reader in readers)
            {
                reader.printData();
            }
            string[] array = { "\"Преступление и наказание\" - Достоевский Ф. М.", "\"Властелин колец\" - Дж. Р. Р. Толкин", "\"Мастер и Маргарита\" - Булгаков М. А." };
            readers[1].takeBook(3);
            readers[2].takeBook(array);
            readers[2].returnBook(5);
            readers[1].returnBook(array);
        }
    }
    }
namespace readers
{
    internal class Reader
    {
        private string name;
        int СardNumber;
        string faculty;
        private DateTime dateBirth;
        string phoneNumber;

        public Reader(string name, int libraryСardNumber, string faculty, DateTime dateOfBirth, string phoneNumber)
        {
            this.name = name;
            this.СardNumber = libraryСardNumber;
            this.faculty = faculty;
            this.dateBirth = dateOfBirth;
            this.phoneNumber = phoneNumber;
        }

        public void printData()
        {
            Console.WriteLine("Имя: " + name + ", номер читательского билета: " + СardNumber + ", факультет: " + faculty + ", дата рождения: " + dateBirth + ", номер телефона: " + phoneNumber);
        }

        public void takeBook(int numberOfBooks)
        {
            Console.WriteLine(name + " взял " + numberOfBooks + " книг");
        }

        public void takeBook(params string[] bookTitles)
        {
            Console.WriteLine(name + " взял книги: " + string.Join(", ", bookTitles));
        }

        public void returnBook(int numberOfBooks)
        {
            Console.WriteLine(name + " вернул " + numberOfBooks + " книг");
        }

        public void returnBook(params string[] bookTitles)
        {
            Console.WriteLine(name + " вернул книги: " + string.Join(", ", bookTitles));
        }
    }
}
namespace students
{
    internal class Student
    {
        string name;
        int group;
        private int age;

        public Student(string name, int group, int age)
        {
            this.name = name;
            this.group = group;
            this.age = age;
        }

        public void printData()
        {
            Console.WriteLine("Имя: " + name + ", группа: " + group + ", возраст: " + age);
        }
    }
}
