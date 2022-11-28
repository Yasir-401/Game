using System;
using System.Collections.Generic;
using System.Text;
using MyGame.Hitboxes;
using MyGame.interfaces;

namespace MyGame.Inventories
{
  public  class SpaceInventory:IInventory<HitBox>
  {
        #region Fields
        private static readonly SpaceInventory _instance = new SpaceInventory(); 
        #endregion
        #region Properties
        public List<HitBox> Items { get; set; }
        #endregion
        #region Methods
        private SpaceInventory()
        {
            Items = new List<HitBox>();
        }
        public static SpaceInventory GetInstance() => _instance;
        #endregion
  }
}
