using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace PongTest
{
    class Player
    {
        int lives = 3;
        public Vector2 size = new Vector2(10, 80);
        public Vector2 coor = new Vector2(50, 0);
        public Vector2 vel = new Vector2(10, 10);
        

        public void Move(string ButtonPressed)
        {
            if (ButtonPressed == "S")
            {
                coor.Y += vel.Y;
            }
            if (ButtonPressed == "W")
            {
                coor.Y -= vel.Y;
            }
            if (ButtonPressed == "D")
            {
                //coor.X += vel.X;
            }
            if (ButtonPressed == "A")
            {
                //coor.X -= vel.X;
            }
            return;
        }
    }
}
