using System.Collections.Generic;
using Microsoft.Xna.Framework;
using MyGame.BaseClasses;
using MyGame.CollisionDetectors;
using MyGame.Enums;
using MyGame.FiniteStates.HeroStates;
using MyGame.interfaces;
using MyGame.Inventories;

namespace MyGame.Movers
{
    public class CharacterMover : IMover
    {
        #region Fields
        private readonly IComplexCollider _collideChecker;
        #endregion
        #region Methods
        public CharacterMover()
        {
            _collideChecker = new GameCharacterCollisionDetector();
        }

        public Vector2 Move(CharacterStatus status, Sprite sprite, Vector2 speed)
        {
            var isColliding = false;

            isColliding = _collideChecker.HasCollided(sprite,
                (List<Sprite>)CharacterInventory.GetInstance().Items);
            if (isColliding&&((IMoveable)sprite).InputStatus!=CharacterStatus.jumping)
                ((IMoveable)sprite).InputStatus = CharacterStatus.Idle;
            if (!isColliding)
            {
                switch (status)
                {
                    case CharacterStatus.WalkingRight:
                        speed = new Vector2(3, 0);
                        break;
                    case CharacterStatus.WalkingLeft:
                        speed = new Vector2(-3, 0);
                        break;
                    case CharacterStatus.Falling:
                        speed = new Vector2(0, 15.0f);
                        break;
                    case CharacterStatus.jumping:
                        int speedVariable = 4;
                        if (sprite.State.GetType() == typeof(JumpLeft))
                            speedVariable *= -1;
                        speed = new Vector2(speedVariable, -15);
                        break;
                }
                sprite.Position += speed;
            }

            return sprite.Position;
        }

        #endregion
    }
}