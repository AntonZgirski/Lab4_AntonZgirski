using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
  public interface IGetDocInfo
  {
    string PrintInfo();
  }

  public class ContractForSupply : IGetDocInfo
  {
    public int numDoc;
    public string productType;
    public int countProduct;
    public string dateDocument;

    public ContractForSupply(int num, string type, int count, string date)
    {      
      numDoc = num;
      productType = type;
      countProduct = count;
      dateDocument = date;
    }

    public string PrintInfo()
    {
      return $"Num document {numDoc.ToString()}. Product type {productType}. Count product {countProduct.ToString()}. Date document {dateDocument}.";
    }
  }

  public class ContractWithEmployee : IGetDocInfo
  {
    public int numDoc;
    public string dateDocument;
    public string dateEndDocument;
    public string nameEmployee;

    public ContractWithEmployee(int num, string date, string enddate, string name)
    {
      numDoc = num;
      dateDocument = date;
      dateEndDocument = enddate;
      nameEmployee = name;
    }

    public string PrintInfo()
    {
      return $"Num document {numDoc.ToString()}. Date document {dateDocument}. End date document {dateEndDocument}. Name employee {nameEmployee}.";
    }
  }

  public class FinancialInvoice : IGetDocInfo
  {
    public int numDoc;
    public string dateDocument;
    public double allSum;
    public string codeDepartment;

    public FinancialInvoice(int num, string date, double sum, string code)
    {
      numDoc = num;
      dateDocument = date;
      allSum = sum;
      codeDepartment = code;
    }

    public string PrintInfo()
    {
      return $"Num document {numDoc.ToString()}. Date document {dateDocument}. Total sum {String.Format("{0:f2}",allSum)}. Code dedpartment {codeDepartment}.";
    }
  }

  public class Registr
  {
    private Dictionary<string, IGetDocInfo> reg = new Dictionary<string, IGetDocInfo>();

    public void AddRegistr(string num, IGetDocInfo doc)
    {
      reg.Add(num, doc);
    }

    public string Invoker(string num)
    {
      return reg[num].PrintInfo();
    }
  }
}
