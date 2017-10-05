using System;
using Csla;

namespace ClassLibrary1
{
  [Serializable]
  public class SomeBusinessClass : BusinessBase<SomeBusinessClass>, ISomeBusinessClass
  {

  }

  public interface ISomeBusinessClass : IBusinessBase
  {

  }
}
