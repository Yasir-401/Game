using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using MyGame.Enums;
using MyGame.Hitboxes;
using MyGame.interfaces;

namespace MyGame.Inventories
{
    public class ScreenBoundsInventory : IInventory<HitBox>
    {
        #region Fields

        private static readonly ScreenBoundsInventory _instance = new ScreenBoundsInventory();

        #endregion
        #region Properties

        public List<HitBox> Items { get; set; } = new List<HitBox>();
        public int ScreenWidth { get; set; } = 1024;
        public int ScreenHeight { get; set; } = 720;

        #endregion
        #region Methods

        private ScreenBoundsInventory()
        {
            Items.Add(new HitBox(new Rectangle(0, -ScreenWidth, ScreenWidth, ScreenWidth),HitBoxType.Bottom,new Rectangle(0,0,0,0),new Tuple<int, int>(ScreenWidth*2,0)));
            Items.Add(new HitBox(new Rectangle(-ScreenWidth, 0, ScreenWidth+20, ScreenHeight),HitBoxType.Right,new Rectangle(0,0,200,ScreenHeight),new Tuple<int, int>(200*2,ScreenHeight*2)));
            Items.Add(new HitBox(new Rectangle(ScreenWidth, 0, 1000, ScreenHeight),HitBoxType.Left,new Rectangle(0,0,200,ScreenHeight),new Tuple<int, int>(200*2,ScreenHeight*2)));
            Items.Add(new HitBox(new Rectangle(0, ScreenHeight , ScreenWidth, 500),HitBoxType.Top,new Rectangle(0,0,ScreenWidth,ScreenHeight),new Tuple<int, int>(ScreenWidth*2,100*2)));
        }

        public static ScreenBoundsInventory GetInstance()
        {
            return _instance;
        }

        #endregion
    }
}