using System;

class Employee{
  string firstName;
  string lastName;
  string id;
  int age;
  string address;
  string phoneNumber;
  string title;
  double yearlySalary;
  string employmentStatus;

public Employee()
{
string firstName = "Unknown";
string lastName = "Unknown";
string id = "Unknown";
int age = 0;
string employmentStatus = "active";
}

public Employee(string firstName, string lastName, string id, int age)
{
string fn1 = firstName;
string ln1 = lastName;
string id1 = id;
int age1 = age;
}
public void Intro()
{
Console.WriteLine("First Name: " + firstName);
Console.WriteLine("Last Name: " + lastName);
Console.WriteLine("ID: " + id);
Console.WriteLine("Age: " + Convert.ToString(age));
Console.WriteLine("Employment Status: " + employmentStatus);
}

}