// See https://aka.ms/new-console-template for more information
using Composite.Concept;
using Composite.Exercise;

Console.WriteLine("Welcome to Composite Design Pattern!");

var group1 = new Group();
group1.AddShape(new Shape()); // imaginary rectangle 1
group1.AddShape(new Shape()); // imaginary rectangle 2

var group2 = new Group();
group2.AddShape(new Shape()); // imaginary Circle 1
group2.AddShape(new Shape()); // imaginary Circle 2

var group3 = new Group();
group3.AddShape(group1);
group3.AddShape(group2);
group3.Render();
group3.Move();

var subTeam1 = new Team();
subTeam1.AddTeam(new Truck());
subTeam1.AddTeam(new HumanResource());
subTeam1.AddTeam(new HumanResource());

var subTeam2 = new Team();
subTeam2.AddTeam(new Truck());
subTeam2.AddTeam(new HumanResource());
subTeam2.AddTeam(new HumanResource());

var team = new Team();
team.AddTeam(subTeam1);
team.AddTeam(subTeam2);

team.Deploy();
//team.Move();
