using System;
using Csla;

namespace netcore_csla_serialization
{
  class Program
  {
    static void Main(string[] args)
    {
      var obj = Csla.DataPortal.Create<SomeBusinessClass>();
      obj = obj.Clone();
      Console.WriteLine("Hello World!");
      Console.ReadLine();
    }
  }


  [Serializable]
  public class SomeBusinessClass : BusinessBase<SomeBusinessClass>, ISomeBusinessClass
  {

  }

  public interface ISomeBusinessClass : IBusinessBase
  {

  }
}
