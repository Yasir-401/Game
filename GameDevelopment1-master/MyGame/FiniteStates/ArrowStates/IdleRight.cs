using System;
using System.Collections.Generic;
using System.Text;
using MyGame.BaseClasses.SpecificCharacterStates;
using MyGame.Enums;
using MyGame.Factory_Classes;
using MyGame.GameCharacters;

namespace MyGame.FiniteStates.ArrowStates
{
  public  class IdleRight:ArrowStateBase
    {
        #region Methods
        public IdleRight(Arrow arrow) : base(arrow)
        {
            Animation = new ArrowAnimationFactory().CreateAnimation(AnimationType.IdleRight, instance.Position);
        } 
        #endregion
    }
}
