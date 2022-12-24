using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
  public interface IJobTitle
  {
    string GetJobTitle();
  }

  public class Director : IJobTitle
  {
    public string GetJobTitle()
    {
      return "Director";
    }
  }
  public class Worker : IJobTitle
  {
    public string GetJobTitle()
    {
      return "Worker";
    }
  }
  public class Accountant : IJobTitle
  {
    public string GetJobTitle()
    {
      return "Accountant";
    }
  }

  class JobTitle
  {
    private IJobTitle _jobtitle;
    public JobTitle(IJobTitle jobtitle)
    {
      _jobtitle = jobtitle;
    }

    public string PrintJobTitle()
    {
      return _jobtitle.GetJobTitle();
    }
  }
}