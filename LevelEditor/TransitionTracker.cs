using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelEditor
{
    class TransitionTracker
    {
        //fields - tracker for each direction a screen can be exited
        //keep track of which screen to send the player to
        private int top;
        private int bottom;
        private int left;
        private int right;

        //properties
        public int Top { get { return top; } set { top = value; } }
        public int Bottom { get { return bottom; } set { bottom = value; } }
        public int Left { get { return left; } set { left = value; } }
        public int Right { get { return right; } set { right = value; } }

        //constructor - default, set all to -1
        public TransitionTracker()
        {
            top = -1;
            bottom = -1;
            left = -1;
            right = -1;
        }

        //methods

        //sets each tracker to -1 if > max
        public void ResetIfOver(int max)
        {
            if (top > max) top = -1;
            if (bottom > max) bottom = -1;
            if (left > max) left = -1;
            if (right > max) right = -1;
        }
    }
}
