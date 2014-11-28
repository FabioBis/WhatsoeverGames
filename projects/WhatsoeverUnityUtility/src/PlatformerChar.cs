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
        // Is the character facing right?
        private bool facingRight;
        // Primary weapon.
        private AWeapon primaryWeapon;
        // Secondary Weapon.
        private AWeapon secondaryWeapon;

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
            float forceJump,
            bool facingR,
            AWeapon primary,
            AWeapon secondary
            )
        {
            this.controlManager = controlManager;
            this.state = charState;
            this.healt = h;
            this.maxSpeed = speedMax;
            this.moveForce = forceMove;
            this.jumpForce = forceJump;
            this.facingRight = facingR;
            this.primaryWeapon = primary;
            this.secondaryWeapon = secondary;
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
        public void Move(float horizontal)
        {
            controlManager.Move(state, this, horizontal);
        }

        /// <summary>
        /// Let the character jump.
        /// </summary>
        public void Jump()
        {
            controlManager.Jump(state, this);
            state = PlatformerJumpingState.Instance();
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
        public void Duck()
        {
            controlManager.Duck(state, this);
            state = PlatformerDuckingState.Instance();
        }

        /// <summary>
        /// Let the character climb.
        /// </summary>
        public void Climb()
        {
            controlManager.Climb(state, this);
            state = PlatformerClimbingState.Instance();
        }

    }
}
