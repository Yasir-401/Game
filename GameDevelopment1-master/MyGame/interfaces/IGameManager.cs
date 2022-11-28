using System;
using System.Collections.Generic;
using System.Text;
using MyGame.BaseClasses;
using MyGame.Hitboxes;

namespace MyGame.interfaces
{
  public  interface IGameManager
  {
      bool Manage(Sprite sprite,HitBox hitBox1,HitBox hitBox2);
  }
}
