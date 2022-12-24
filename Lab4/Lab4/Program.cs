using System;

namespace Lab4
{
  class Program
  {
    static void Main(string[] args)
    {
      // 1
      double sum = 0;
      Figure[] figures = new Figure[5] { new Triangle(3, 4, 5, 4), new Rectangle(4, 6), new Circle(5), new Rectangle(2, 10), new Circle(8) };
      foreach (var f in figures)
      {        
        sum += f.GetPerimetr();
      }

      Console.WriteLine($"Sum perimetr = {sum}");
      Console.WriteLine();

      // 2
      var job = new JobTitle(new Director());
      var job1 = new JobTitle(new Worker());
      var job2 = new JobTitle(new Accountant());

      Console.WriteLine(job.PrintJobTitle());
      Console.WriteLine(job1.PrintJobTitle());
      Console.WriteLine(job2.PrintJobTitle());
      Console.WriteLine();

      // 3
      var reg = new Registr();
      reg.AddRegistr("1", new ContractForSupply(5232, "Food", 10, "12.12.2022"));
      reg.AddRegistr("2", new ContractForSupply(5234234, "Car", 12, "11.11.2022"));
      reg.AddRegistr("3", new ContractForSupply(51231232, "Computer", 5, "13.11.2022"));      
      reg.AddRegistr("4", new ContractWithEmployee(2836544, "10.12.2000", "10.12.2030", "Maks"));
      reg.AddRegistr("5", new ContractWithEmployee(2134123, "25.05.2020", "25.05.2023", "Anna"));
      reg.AddRegistr("6", new ContractWithEmployee(2345234, "10.04.2022", "10.04.2025", "Alex"));
      reg.AddRegistr("7", new FinancialInvoice(17234,"25.11.2022",1243734.32847,"CB-01"));
      reg.AddRegistr("8", new FinancialInvoice(3567,"14.07.2021",1023.123,"CB-02"));
      reg.AddRegistr("9", new FinancialInvoice(0938,"08.05.2020",3456.643,"CB-03"));
      reg.AddRegistr("10", new ContractWithEmployee(2345345, "20.01.2009", "20.01.2017", "Baraсk Obama"));

      Console.WriteLine(reg.Invoker("10"));
    }
  }
}
