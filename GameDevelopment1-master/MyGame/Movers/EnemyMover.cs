using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using MyGame.BaseClasses;
using MyGame.CollisionDetectors;
using MyGame.Enums;
//using MyGame.FiniteStates.HeroStates;
using MyGame.GameCharacters;
using MyGame.interfaces;
using MyGame.Inventories;
using MyGame.FiniteStates.SmallNinjaStates;
namespace MyGame.Movers
{
   public class EnemyMover:IMover
    {
        #region Fields
        private readonly IComplexCollider _collideChecker;
        private bool isTrue = false;
        #endregion
        public EnemyMover()
        {
            _collideChecker = new GameCharacterCollisionDetector();
        }
        public Vector2 Move(CharacterStatus status, Sprite sprite, Vector2 speed)
        {
            var isColliding = false;
            isColliding = _collideChecker.HasCollided(sprite,
                (List<Sprite>)CharacterInventory.GetInstance().Items);
            if (((IMoveable)sprite).InputStatus == CharacterStatus.Attacking)
                isTrue = false;

            if (isColliding && ((IMoveable)sprite).InputStatus != CharacterStatus.jumping)
            {
                //((IMoveable)sprite).InputStatus = CharacterStatus.Idle;
                Random rng = new Random();
                int generatedValue = rng.Next(1, 20);
                if (((IMoveable)sprite).InputStatus == CharacterStatus.WalkingLeft ||
                    ((IMoveable)sprite).InputStatus == CharacterStatus.Idle)
                {
                    ((IMoveable)sprite).InputStatus = CharacterStatus.WalkingRight;
                }
                else if (((IMoveable)sprite).InputStatus == CharacterStatus.WalkingRight)
                {
                    ((IMoveable)sprite).InputStatus = CharacterStatus.WalkingLeft;
                }
                if (generatedValue == 1 && !isTrue)
                {
                    if (sprite is SmallNinja s)
                    {
                        ((IMoveable)sprite).InputStatus = CharacterStatus.Attacking;
                        if (((IMoveable)sprite).InputStatus == CharacterStatus.WalkingLeft)
                            sprite.ChangeState(new AttackRight((SmallNinja)sprite));
                        else
                            sprite.ChangeState(new AttackLeft((SmallNinja)sprite));
                    }
                    else if (sprite is LongNinja l)
                    {
                        ((IMoveable)sprite).InputStatus = CharacterStatus.Attacking;
                        if (((IMoveable)sprite).InputStatus == CharacterStatus.WalkingLeft)
                            sprite.ChangeState(new FiniteStates.LongNinjaStates.AttackRight((LongNinja)sprite));
                        else
                            sprite.ChangeState(new FiniteStates.LongNinjaStates.AttackLeft((LongNinja)sprite));
                    }
                    isTrue = true;
                }
            }
            if (((IMoveable)sprite).InputStatus == CharacterStatus.Attacking && !isTrue)
            {
                if (sprite.State.GetType() == typeof(AttackRight))
                {
                    ((IMoveable)sprite).InputStatus = CharacterStatus.WalkingLeft;
                }
                else
                    ((IMoveable)sprite).InputStatus = CharacterStatus.WalkingRight;
            }
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
    }
}
