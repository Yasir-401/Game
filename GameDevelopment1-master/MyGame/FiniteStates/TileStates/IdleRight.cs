using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MyGame.BaseClasses;
using MyGame.BaseClasses.SpecificCharacterStates;
using MyGame.Enums;
using MyGame.Factory_Classes;
using MyGame.GameCharacters;

namespace MyGame.FiniteStates.TileStates
{
  public  class IdleRight:TileState
    {
        #region Methods
        public IdleRight(Tile tile) : base(tile)
        {
            Animation = new TileAnimationFactory().CreateAnimation(AnimationType.IdleRight, instance.Position);
        } 
        #endregion
    }
}
