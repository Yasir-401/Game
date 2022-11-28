using System;
using System.Collections.Generic;
using System.Text;
using MyGame.BaseClasses.SpecificCharacterStates;
using MyGame.Enums;
using MyGame.Factory_Classes;
using MyGame.GameCharacters;

namespace MyGame.FiniteStates.spikyTrapStates
{
  public  class IdleRight:SpikyTrapState
    {
        #region Methods
        public IdleRight(SpikyTrap trap) : base(trap)
        {
            Animation = new SpikyTrapAnimationFactory().CreateAnimation(AnimationType.IdleRight, instance.Position);
        } 
        #endregion
    }
}
