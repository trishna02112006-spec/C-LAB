using System;
class Person{
    public string Name;
    public int Age;
    public void GetPersonData(){
        Console.Write("Enter Name: ");
        Name = Console.ReadLine();
        Console.Write("Enter Age: ");
        Age = Convert.ToInt32(Console.ReadLine());
    }
    public void DisplayPersonData(){
        Console.WriteLine("\nPerson Details");
        Console.WriteLine("Name        : " + Name);
        Console.WriteLine("Age         : " + Age);
    }}
class Student : Person{
    public int RollNo;
    public string Department;
    public int Marks;
    public void GetStudentData(){
        Console.Write("Enter Roll Number: ");
        RollNo = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Department: ");
        Department = Console.ReadLine();
        Console.Write("Enter Marks: ");
        Marks = Convert.ToInt32(Console.ReadLine());
    }
    public void DisplayStudentData(){
        Console.WriteLine("Roll Number : " + RollNo);
        Console.WriteLine("Department  : " + Department);
        Console.WriteLine("Marks       : " + Marks);
    }}
class Program{
    static void Main(string[] args){
        Student s = new Student();
        Console.WriteLine("Enter Student Details");
        s.GetPersonData();
        s.GetStudentData();
        Console.WriteLine("\nStudent Information");
        s.DisplayPersonData();
        s.DisplayStudentData();
       Console.ReadLine();
 }}
