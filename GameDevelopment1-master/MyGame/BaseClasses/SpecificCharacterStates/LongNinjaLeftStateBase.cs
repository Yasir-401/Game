using System;
using System.Collections.Generic;
using System.Text;
using MyGame.GameCharacters;
using MyGame.interfaces;

namespace MyGame.BaseClasses.SpecificCharacterStates
{
  public  class LongNinjaLeftStateBase:BaseCharacterStateLeft
    {
        #region Methods
        public LongNinjaLeftStateBase(LongNinja ninja) : base(ninja) { } 
        #endregion
    }
}
