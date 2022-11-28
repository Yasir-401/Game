using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using MyGame.Hitboxes;
using MyGame.interfaces;

namespace MyGame.Filters
{
    public class HitboxFilter : IFilterable<HitBox>
    {
        #region Methods
        public List<HitBox> Filter(List<HitBox> list, Expression<Func<HitBox, bool>> filterCriteria) => list.Where(filterCriteria.Compile()).ToList(); 
        #endregion
    }
}
