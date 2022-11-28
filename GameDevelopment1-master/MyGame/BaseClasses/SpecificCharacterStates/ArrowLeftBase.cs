using System;
using System.Collections.Generic;
using System.Text;
using MyGame.GameCharacters;

namespace MyGame.BaseClasses.SpecificCharacterStates
{
   public abstract class ArrowLeftBase:BaseCharacterStateLeft
    {
        #region Methods
        public ArrowLeftBase(Arrow arrow) : base(arrow) { } 
        #endregion
    }
}
