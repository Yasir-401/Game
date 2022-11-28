using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MyGame.interfaces
{
  public  interface IFilterable<T>
  {
      public List<T> Filter(List<T> list,Expression<Func<T, bool>> filterCriteria);
  }
}
