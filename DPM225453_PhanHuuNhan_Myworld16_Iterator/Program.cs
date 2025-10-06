using System;
using System.Collections.Generic;

namespace DPM225423_NguyenNgocHuy_Myworld15_Iterator
{
    /// <summary>
    /// Iterator Design Pattern - Ví dụ với danh sách Sinh viên
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Tạo collection Sinh viên
            StudentCollection students = new StudentCollection();
            students[0] = new Student("Nguyen Van A");
            students[1] = new Student("Tran Thi B");
            students[2] = new Student("Le Van C");
            students[3] = new Student("Pham Thi D");
            students[4] = new Student("Hoang Van E");

            // Tạo Iterator
            StudentIterator iterator = students.CreateIterator();

            // Ví dụ: duyệt qua từng sinh viên
            Console.WriteLine("Danh sách sinh viên:");
            for (Student sv = iterator.First(); !iterator.IsDone; sv = iterator.Next())
            {
                Console.WriteLine(sv.Name);
            }

            // Đổi Step = 2 để duyệt cách 1 sinh viên
            iterator.Step = 2;
            Console.WriteLine("\nDuyệt cách 1 sinh viên:");
            for (Student sv = iterator.First(); !iterator.IsDone; sv = iterator.Next())
            {
                Console.WriteLine(sv.Name);
            }

            Console.ReadKey();
        }
    }

    /// <summary>
    /// Lớp Sinh viên
    /// </summary>
    public class Student
    {
        string name;

        public Student(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }
    }

    /// <summary>
    /// Aggregate interface
    /// </summary>
    public interface IStudentCollection
    {
        StudentIterator CreateIterator();
    }

    /// <summary>
    /// ConcreteAggregate - Danh sách sinh viên
    /// </summary>
    public class StudentCollection : IStudentCollection
    {
        List<Student> students = new List<Student>();

        public StudentIterator CreateIterator()
        {
            return new StudentIterator(this);
        }

        public int Count
        {
            get { return students.Count; }
        }

        // Indexer
        public Student this[int index]
        {
            get { return students[index]; }
            set { students.Add(value); }
        }
    }

    /// <summary>
    /// Iterator interface
    /// </summary>
    public interface IStudentIterator
    {
        Student First();
        Student Next();
        bool IsDone { get; }
        Student CurrentItem { get; }
    }

    /// <summary>
    /// ConcreteIterator
    /// </summary>
    public class StudentIterator : IStudentIterator
    {
        StudentCollection collection;
        int current = 0;
        int step = 1;

        public StudentIterator(StudentCollection collection)
        {
            this.collection = collection;
        }

        public Student First()
        {
            current = 0;
            return collection[current] as Student;
        }

        public Student Next()
        {
            current += step;
            if (!IsDone)
                return collection[current] as Student;
            else
                return null;
        }

        public int Step
        {
            get { return step; }
            set { step = value; }
        }

        public Student CurrentItem
        {
            get { return collection[current] as Student; }
        }

        public bool IsDone
        {
            get { return current >= collection.Count; }
        }
    }
}
