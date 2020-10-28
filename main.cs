using System;

class MainClass {
  public static void Main (string[] args) {
    Employee nullVoid = new Employee();
    nullVoid.Intro();
    Employee johnSmith = new Employee("John", "Smith", "1234", 45);
    johnSmith.Intro();
  }
}
//Alright so I got it to print what I want, I get how to use Methods I think but it doesn't seem to print the values I have assigned?