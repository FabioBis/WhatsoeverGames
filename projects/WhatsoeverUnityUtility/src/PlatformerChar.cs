using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

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

        /// <summary>
        /// Default constructor.
        /// </summary>
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


        /// <summary>
        /// Set the current character state to <code>newState</code>.
        /// </summary>
        public void SetState(APlatformerCharState newState)
        {
            state = newState;
        }

        /// <summary>
        /// Let the character move horizontally.
        /// </summary>
        /// <param name="horizontal">Horizontal space.</param>
        /// <param name="rigidbody">Character Rigidbody2D.</param>
        public void Move(float horizontal, Rigidbody2D rigidbody)
        {
            controlManager.Move(state, horizontal, rigidbody);
        }

        /// <summary>
        /// Let the character jump.
        /// </summary>
        public void Jump(Rigidbody2D rigidbody)
        {
            controlManager.Jump(state, rigidbody);
            state = new PlatformerJumpState(
                state.GetFacingRight(),
                maxSpeed,
                moveForce,
                jumpForce);
        }

        /// <summary>
        /// Let the character use the given <code>weapon</code>.
        /// </summary>
        public void Fire(AWeapon weapon)
        {
            controlManager.Fire(state, weapon);
        }

        /// <summary>
        /// Let the character duck.
        /// </summary>
        /// <param name="rigidbody"></param>
        public void Duck(Rigidbody2D rigidbody)
        {
            controlManager.Duck(state, rigidbody);
            state = new PlatformerDuckState(
                state.GetFacingRight(),
                maxSpeed,
                moveForce,
                jumpForce);
        }

        /// <summary>
        /// Let the character climb.
        /// </summary>
        /// <param name="rigidbody"></param>
        public void Climb(Rigidbody2D rigidbody)
        {
            controlManager.Climb(state, rigidbody);
            state = new PlatformerClimbState(
                state.GetFacingRight(),
                maxSpeed,
                moveForce,
                jumpForce);
        }

    }
}
