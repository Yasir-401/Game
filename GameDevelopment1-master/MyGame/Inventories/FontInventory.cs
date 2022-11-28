using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using MyGame.Hitboxes;
using MyGame.interfaces;

namespace MyGame.Inventories
{
   public class FontInventory:IInventory<SpriteFont>
   {

        #region Fields
        private static FontInventory _instance = new FontInventory(); 
        #endregion
        #region Methods
        private FontInventory() { }
        public static FontInventory GetInstance() => _instance;
        public SpriteFont GiveRequestedResource(string name)=>Items[0];
        #endregion

        #region Properties
        public List<SpriteFont> Items { get; set; } = new List<SpriteFont>(); 
        #endregion
    }
}
