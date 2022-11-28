using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.Xna.Framework;
using MyGame.Animations;
using MyGame.BaseClasses;
using MyGame.Enums;
using MyGame.Filters;
using MyGame.GameCharacters;
using MyGame.GameManagers;
using MyGame.Hitboxes;
using MyGame.interfaces;
using MyGame.Inventories;

namespace MyGame.CollisionDetectors
{
    public class GameCharacterCollisionDetector : IComplexCollider
    {
        #region Methods
        private HitBoxType GiveFilterCriteria(Sprite sprite)
        {
            HitBoxType filterCriteria = HitBoxType.Normal;
            switch (((IMoveable)sprite).InputStatus)
            {
                
                case CharacterStatus.WalkingRight:
                    filterCriteria = HitBoxType.Left;
                    break;
                case CharacterStatus.WalkingLeft:
                    filterCriteria = HitBoxType.Right;
                    break;
                case CharacterStatus.Falling:
                    filterCriteria = HitBoxType.Top;
                    break;
                case CharacterStatus.jumping:
                    filterCriteria = HitBoxType.Bottom;
                    break;
              
            }
            return filterCriteria;
        }

        private HitBoxType GiveHitboxFilterCriteriaForSpecificCharacter(Sprite sprite)
        {
            var hitbox = HitBoxType.Normal;
            switch (((IMoveable)sprite).InputStatus)
            {
                case CharacterStatus.WalkingRight:
                    hitbox = HitBoxType.Right;
                    break;
                case CharacterStatus.WalkingLeft:
                    hitbox = HitBoxType.Left;
                    break;
                case CharacterStatus.Falling:
                    hitbox = HitBoxType.Bottom;
                    break;
                case CharacterStatus.jumping:
                    hitbox = HitBoxType.Top;
                    break;
            }
            return hitbox;
        }
        public bool HasCollided(Sprite sprite, List<Sprite> Sprites)
        {
            var filterCriteria = GiveFilterCriteria(sprite);
            HitboxFilter filter = new HitboxFilter();
            var list = new List<HitBox>();
            var ListWithoutEntity = Sprites.Where(x => x != sprite);
            foreach (var spritess in ListWithoutEntity)
            {
                list.AddRange(((BaseCharacterState)spritess.State).GetHitboxes());
            }
            list.AddRange(ScreenBoundsInventory.GetInstance().Items);
            if (filterCriteria == HitBoxType.Attack)
            {
                Debug.Write("naber aga");
            }
            var temporaryList = filter.Filter(((BaseCharacterState)sprite.State).Animation.CurrentFrame.HitBoxes,
                x => x.Type == GiveHitboxFilterCriteriaForSpecificCharacter(sprite)||x.Type==HitBoxType.Attack);
            list = filter.Filter(list,
                x => x.Type == filterCriteria || x.Type == HitBoxType.Normal||x.Type==HitBoxType.Attack);
            var bottomhitboxes =
                ((BaseCharacterState)sprite.State).Animation.CurrentFrame.HitBoxes.Where(x =>
                    x.Type == HitBoxType.Bottom).ToList();
            bottomhitboxes = bottomhitboxes;
          
            for (var i = 0; i < temporaryList.Count; i++)
            {
                foreach (var collideable in list)
                {
                    if (((IMoveable)sprite).InputStatus == CharacterStatus.Falling)
                    {
                        var futureRectangle = new Rectangle(
                            temporaryList[i].Source.X,
                            temporaryList[i].Source.Y + 15,
                            temporaryList[i].Source.Width,
                            temporaryList[i].Source.Height);
                        var tunnelHeightTemporaryResult =
                            futureRectangle.Y + futureRectangle.Height - temporaryList[i].Source.Y;
                        var tunnelRectangle = new Rectangle(temporaryList[i].Source.X, temporaryList[i].Source.Y,
                            temporaryList[i].Source.Width,
                            tunnelHeightTemporaryResult);
                        if (tunnelRectangle.Intersects(collideable.Source))
                        {
                            GameManager.Getinstance().Manage(sprite, temporaryList[i], collideable);
                            return true;
                        }
                    }
                    else if (((IMoveable)sprite).InputStatus == CharacterStatus.jumping)
                    {
                        var futureRectangle = new Rectangle(
                            temporaryList[i].Source.X,
                            temporaryList[i].Source.Y - 15,
                            temporaryList[i].Source.Width,
                            temporaryList[i].Source.Height);

                        var tunnelHeightTemporaryResult = temporaryList[i].Source.Y - futureRectangle.Y;
                        var tunnelRectangle = new Rectangle(futureRectangle.X, futureRectangle.Y,
                            futureRectangle.Width,
                            tunnelHeightTemporaryResult);
                        if (tunnelRectangle.Intersects(collideable.Source))
                        {
                            GameManager.Getinstance().Manage(sprite, temporaryList[i], collideable);

                            return true;
                        }
                    }
                    else if (((IMoveable)sprite).InputStatus == CharacterStatus.WalkingRight)
                    {
                        var futureRectangle = new Rectangle(
                            temporaryList[i].Source.X + 5,
                            temporaryList[i].Source.Y,
                            temporaryList[i].Source.Width,
                            temporaryList[i].Source.Height);
                        var tunnelHeightTemporaryResult =
                            futureRectangle.X + futureRectangle.Width - temporaryList[i].Source.X;
                        var tunnelRectangle = new Rectangle(temporaryList[i].Source.X, temporaryList[i].Source.Y,
                            temporaryList[i].Source.Width + tunnelHeightTemporaryResult,
                            temporaryList[i].Source.Height);
                        if (tunnelRectangle.Intersects(collideable.Source))
                        {
                            GameManager.Getinstance().Manage(sprite, temporaryList[i], collideable);
                            return true;
                        }
                    }
                    else if (((IMoveable)sprite).InputStatus == CharacterStatus.WalkingLeft)
                    {
                        var futureRectangle = new Rectangle(
                            temporaryList[i].Source.X - 5,
                            temporaryList[i].Source.Y,
                            temporaryList[i].Source.Width,
                            temporaryList[i].Source.Height);
                        var tunnelHeightTemporaryResult = temporaryList[i].Source.X - futureRectangle.X;
                        var tunnelRectangle = new Rectangle(futureRectangle.X, futureRectangle.Y,
                            temporaryList[i].Source.Width - tunnelHeightTemporaryResult,
                            futureRectangle.Height);
                        if (tunnelRectangle.Intersects(collideable.Source))
                        {
                            GameManager.Getinstance().Manage(sprite, temporaryList[i], collideable);
                            return true;
                        }
                    }
                    else
                    {
                        if (((IMoveable)sprite).InputStatus != CharacterStatus.Attacking)
                        {
                            for (int j = 0; j < bottomhitboxes.Count; j++)
                            {
                                foreach (var collideableItem in list)
                                {
                                    if (collideableItem.Source.Intersects(bottomhitboxes[j].Source))
                                        return true;
                                }
                                foreach (var screenboundItem in ScreenBoundsInventory.GetInstance().Items)
                                {
                                    if (screenboundItem.Source.Intersects(bottomhitboxes[j].Source))
                                        return true;
                                }
                            }
                            for (int j = 0; j < temporaryList.Count; j++)
                            {
                                foreach (var item in SpaceInventory.GetInstance().Items)
                                {
                                    if (temporaryList[j].Source.Intersects(item.Source))
                                    {
                                        GameManager.Getinstance().Manage(sprite, temporaryList[j], item);
                                        return false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return false;
        } 
        #endregion
    }
    }
