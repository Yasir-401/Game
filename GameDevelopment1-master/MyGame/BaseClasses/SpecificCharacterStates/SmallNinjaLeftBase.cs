using System;
using System.Collections.Generic;
using System.Text;
using MyGame.GameCharacters;

namespace MyGame.BaseClasses.SpecificCharacterStates
{
  public  abstract class SmallNinjaLeftBase:BaseCharacterStateLeft
    {
        #region Methods
        public SmallNinjaLeftBase(SmallNinja ninja) : base(ninja) { } 
        #endregion
    }
}
