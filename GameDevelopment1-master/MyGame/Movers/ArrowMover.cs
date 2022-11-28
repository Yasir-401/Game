using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Microsoft.Xna.Framework;
using MyGame.BaseClasses;
using MyGame.CollisionDetectors;
using MyGame.Enums;
using MyGame.interfaces;
using MyGame.Inventories;

namespace MyGame.Movers
{
  public  class ArrowMover:IMover
  {
      private IComplexCollider _collideChecker;
        #region Methods
        public ArrowMover()
        {
            _collideChecker = new GameCharacterCollisionDetector();
        }
        public Vector2 Move(CharacterStatus status, Sprite sprite, Vector2 speed)
        {
            var isColliding = false;
            isColliding = _collideChecker.HasCollided(sprite,
               CharacterInventory.GetInstance().Items);
            if (!isColliding)
            {
                switch (status)
                {
                    case CharacterStatus.WalkingRight:
                        speed = new Vector2(5, 0);
                        break;
                    case CharacterStatus.WalkingLeft:
                        speed = new Vector2(-5, 0);
                        break;
                }
                sprite.Position += speed;
            }

            return new Vector2();
        } 
        #endregion
    }
}
