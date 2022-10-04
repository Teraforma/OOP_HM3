// See https://aka.ms/new-console-template for more information


using Console_Application;

var emp1 = new Developer("Vasya");
var emp2 = new Manager("Levi");
var team1 = new Team("Earth");
Console.WriteLine(String.Format("{0} dasd ", "one"));
team1.ShowUp();
team1.ShowUpPlus();

team1.AddMember(emp2);
team1.AddMember(emp1);

team1.ShowUp();
team1.ShowUpPlus();

List<Worker> OutTeamWorkers = new List<Worker>();
OutTeamWorkers.Add(new Developer("Kenni"));
OutTeamWorkers.Add(new Developer("Kunger"));
while (true)//I'm not sure that it's nesesary, so I won't do it 
{
    string input;
    Console.WriteLine("help: AddW, createT, exit");
    input = Console.ReadLine().ToLower();
    if (input == "addw")
    {
        int i = 0;
        foreach (var worker in OutTeamWorkers)
        {
            worker.getName();
            Console.WriteLine(String.Format("{0}) {1}", i, worker.getName()));
            i++;
        }
    }else if(input == "exit")
    {
        break;
    }
}
