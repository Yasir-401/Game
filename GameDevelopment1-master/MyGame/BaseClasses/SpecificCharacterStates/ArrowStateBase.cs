using System;
using System.Collections.Generic;
using System.Text;
using MyGame.GameCharacters;

namespace MyGame.BaseClasses.SpecificCharacterStates
{
  public abstract  class ArrowStateBase:BaseCharacterState
    {
        #region Methods
        public ArrowStateBase(Arrow arrow) : base(arrow) { } 
        #endregion
    }
}
