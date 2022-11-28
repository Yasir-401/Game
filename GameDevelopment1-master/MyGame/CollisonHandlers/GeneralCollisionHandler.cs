using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MyGame.BaseClasses;
using MyGame.Enums;
using MyGame.GameCharacters;
using MyGame.Hitboxes;
using MyGame.interfaces;
using MyGame.Inventories;

namespace MyGame.CollisonHandlers
{
    public class GeneralCollisionHandler : ICollisionHandler
    {
      
        #region Methods
        public Sprite HandleCollision(List<Sprite> entities, Sprite sprite, HitBox hitBox1OfGivenSprite,
           HitBox hitBox2ofSearchedEntity)
        {
         Sprite searchedEntity = null;
        
            if (hitBox2ofSearchedEntity.Type != HitBoxType.Space)
            {


               
              
                    searchedEntity = entities.Where(x =>
                                          ((BaseCharacterState)x.State).Animation.CurrentFrame.HitBoxes.Any(x =>
                                              x.Source == hitBox2ofSearchedEntity.Source)).SingleOrDefault();
                
              
                    var typeOfGivenSprite = sprite.GetType();
                var searchedEntityType = searchedEntity?.GetType();
                var fallingHandling = new Vector2(sprite.Position.X,
                    hitBox2ofSearchedEntity.Source.Y - ((BaseCharacterState)sprite.State).Animation.CurrentFrame
                    .SourceRectangle.Height + 11);
                if (typeOfGivenSprite == typeof(Arrow) &&
                    !SpaceInventory.GetInstance().Items.Contains(hitBox2ofSearchedEntity) &&
                    searchedEntityType != typeof(Hero))
                {
                    CharacterInventory.GetInstance().Items.Remove(sprite);
                    if (searchedEntity is IMoveable && !(searchedEntity is Hero))
                        CharacterInventory.GetInstance().Items.Remove(searchedEntity);
                }

                if (searchedEntityType != null)
                {
                    if (searchedEntityType == typeof(Tile) ||
                        ScreenBoundsInventory.GetInstance().Items.Contains(hitBox2ofSearchedEntity))
                    {
                        if (((IMoveable)sprite).InputStatus == CharacterStatus.Falling)
                        {
                            sprite.Position = fallingHandling;
                        }
                        else if (((IMoveable)sprite).InputStatus == CharacterStatus.jumping)
                        {
                            sprite.Position = new Vector2(sprite.Position.X, hitBox2ofSearchedEntity.Source.Bottom);
                        }
                        else if (((IMoveable)sprite).InputStatus == CharacterStatus.WalkingRight)
                        {
                            sprite.Position =
                                new Vector2(
                                    hitBox2ofSearchedEntity.Source.Left - ((BaseCharacterState)sprite.State).Animation
                                    .CurrentFrame.SourceRectangle.Width, sprite.Position.Y);
                        }
                        else if (((IMoveable)sprite).InputStatus == CharacterStatus.WalkingLeft)
                        {
                            sprite.Position = new Vector2(hitBox2ofSearchedEntity.Source.Right, sprite.Position.Y);
                        }
                    }
                    else if (searchedEntityType == typeof(SpikyTrap))
                    {
                        if (typeOfGivenSprite == typeof(Hero) &&
                            ((IMoveable)sprite).InputStatus == CharacterStatus.Falling &&
                            hitBox1OfGivenSprite.Type == HitBoxType.Bottom)
                            CharacterInventory.GetInstance().Items.Remove(sprite);
                    }
                    else if (hitBox2ofSearchedEntity.Type == HitBoxType.Attack &&
                    (searchedEntityType is LongNinja||searchedEntity is SmallNinja)||hitBox1OfGivenSprite.Type==HitBoxType.Attack&&searchedEntity is Hero)
                    {
                        Hero itemToBeRemoved = null;
                        if (sprite is Hero)
                            itemToBeRemoved = (Hero)sprite;
                        else
                            itemToBeRemoved = (Hero)searchedEntity;
                       
                        CharacterInventory.GetInstance().Items.Remove(itemToBeRemoved);

                    }
                    else if (typeOfGivenSprite == typeof(Hero))
                    {
                        if (hitBox1OfGivenSprite.Type == HitBoxType.Bottom &&
                            ((IMoveable)sprite).InputStatus == CharacterStatus.Falling &&
                            (hitBox2ofSearchedEntity.Type == HitBoxType.Top ||
                             hitBox2ofSearchedEntity.Type == HitBoxType.Normal))
                        {
                            CharacterInventory.GetInstance().Items.Remove(searchedEntity);
                        }
                    }
                }
            }
            else
            {
                if (SpaceInventory.GetInstance().Items.Contains(hitBox2ofSearchedEntity))
                    ((IMoveable)sprite).InputStatus = CharacterStatus.Falling;
            }
            return searchedEntity;
        } 
        #endregion
    }
}
    

