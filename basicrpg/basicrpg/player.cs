using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicrpg
{
    class player
    {


        public void Update(GameTime gameTime)
        {
            
            Keys[] pressed = input_handler_lib.InputHandler.KeyboardState.GetPressedKeys();
            foreach(Keys k in pressed)
            {
                moveBody(k);
            }


            //update their position


            
        }

        //handles all the input
        public void moveBody(Keys k)
        {
            switch (k) 
            { 
                case Keys.Left:
                   // this.velocity.X -= 0.4f;
                    break;
            }

        }

    }
}
