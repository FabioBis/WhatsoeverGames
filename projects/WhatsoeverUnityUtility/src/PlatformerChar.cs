using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Whatsoever2DUnityUtility
{
    /// <summary>
    /// This class represents an abstraction of what a character is within
    /// the Unity environment. To use this class correctly each Unity script
    /// attached to a character (that implements it) must extends this class.
    /// </summary>
    public class PlatformerChar
    {
        // The current character healt.
        private int healt;
        // The maximum speed the character can reach.
        private float maxSpeed;
        // The force applied to character while moving (acceleration).
        private float moveForce;
        // The force applied to character while jumping (deceleration).
        private float jumpForce;

        // The character current state (Standing, Jumping, ...).
        private APlatformerCharState state;
        // The character control manager (Move, Jump, ...).
        private APlatformerControl controlManager;

        public PlatformerChar(
            APlatformerControl controlManager,
            APlatformerCharState charState,
            int h,
            float speedMax,
            float forceMove,
            float forceJump
            )
        {
            this.controlManager = controlManager;
            this.state = charState;
            this.healt = h;
            this.maxSpeed = speedMax;
            this.moveForce = forceMove;
            this.jumpForce = forceJump;
        }

        // TODO
        TODO;

    }
}
