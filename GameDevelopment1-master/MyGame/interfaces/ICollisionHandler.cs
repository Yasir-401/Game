using System;
using System.Collections.Generic;
using System.Text;
using MyGame.BaseClasses;
using MyGame.Hitboxes;

namespace MyGame.interfaces
{
  public  interface ICollisionHandler
  {
      Sprite HandleCollision(List<Sprite> entities,Sprite sprite,HitBox hitBox1OfGivenSprite,HitBox hitBox2ofSearchedEntity);
  }
}
