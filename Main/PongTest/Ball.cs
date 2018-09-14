using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;


namespace PongTest
{
    class Ball
    {
        public Vector2 coor = new Vector2(0, 0);
        Vector2 vel = new Vector2(1, 1);
        Vector2 acc = new Vector2(0.01F, 0.01F);
        public Vector2 squaredim = new Vector2(20, 20);
        public Color color = Color.White;

        public void MoveAndAccelerate()
        {
            coor = coor + vel;
            //vel = vel + acc;
        }

        public void CheckIfCollidedAndBounce(int width,int height)
        {
            if (coor.X < 0 || coor.X > width - squaredim.X)
            {
                vel.X = -vel.X;
                acc.X = -acc.X;
            }
            if (coor.Y < 0 || coor.Y > height - squaredim.Y)
            {
                vel.Y = -vel.Y;
                acc.Y = -acc.Y;
            }
            return;
        }
    }
}
