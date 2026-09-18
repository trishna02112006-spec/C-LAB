using System;
class Student{
    int rollNo;
    string name;
    string department;
    int mark1, mark2, mark3;
    int total;
    double average;
    public void GetData(){
        rollNo = 101;
        name = "Rahul";
        department = "Computer Science";
        mark1 = 85;
        mark2 = 90;
        mark3 = 88;
    }
    public void CalculateTotal(){
        total = mark1 + mark2 + mark3;
    }
    public void CalculateAverage(){
        average = total / 3.0;
    }
    public void DisplayData(){
        Console.WriteLine("******** STUDENT DETAILS ********");
        Console.WriteLine("Roll Number : " + rollNo);
        Console.WriteLine("Name        : " + name);
        Console.WriteLine("Department  : " + department);
        Console.WriteLine("Mark 1      : " + mark1);
        Console.WriteLine("Mark 2      : " + mark2);
        Console.WriteLine("Mark 3      : " + mark3);
        Console.WriteLine("Total Marks : " + total);
        Console.WriteLine("Average     : " + average);
    }
}
class Program{
    static void Main(string[] args){
        Student s1 = new Student();
        s1.GetData();
        s1.CalculateTotal();
        s1.CalculateAverage();
        s1.DisplayData();
        Console.ReadLine();
    }
}

