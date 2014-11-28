using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Whatsoever2DUnityUtility
{
    /// <summary>
    /// This class represents an abstraction of which state a character could
    /// be (state machine). See State Pattern.
    /// Each public class method implements a character action, those methods
    /// require to pass as parameters the Rigidbody2D of the caller (character).
    /// </summary>
    abstract public class APlatformerCharState
    {
        /// <summary>
        /// Allows the character to move horizontally.
        /// </summary>
        /// <param name="hspace">
        /// The amount of movement for the current frame.
        /// </param>
        public void Move(float hspace, PlatformerChar character)
        {
            Rigidbody2D rigidbody = character.GetRigidBody();
            float maxSpeed = character.GetMaxSpeed();
            float moveForce = character.GetMoveForce();
            bool facingRight = character.GetFacingRight();
            if (rigidbody == null)
            {
                throw new NullReferenceException();
            }
            if (hspace * rigidbody.velocity.x < maxSpeed)
            {
                // The character is changing direction (horizontal has a
                // different sign to velocity.x) or hasn't reached maxSpeed.
                // Add a force to the player.
                rigidbody.AddForce(Vector2.right * hspace * moveForce);
            }
            if (Mathf.Abs(rigidbody.velocity.x) > maxSpeed)
            {
                // The player's velocity is greater than the maxSpeed.
                rigidbody.velocity =
                    new Vector2(
                        Mathf.Sign(rigidbody.velocity.x) * maxSpeed,
                        rigidbody.velocity.y
                        );
            }
            if ((hspace > 0 && !facingRight) ||
                (hspace < 0 && facingRight))
            {
                // The character changed direction.
                character.Flip();
            }
        }

        /// <summary>
        /// Allows the character to jump.
        /// </summary>
        public void Jump(PlatformerChar character)
        {
            Rigidbody2D rigidbody = character.GetRigidBody();
            float jumpForce = character.GetJumpForce();
            // Add a vertical force to the player.
            rigidbody.AddForce(new Vector2(0f, jumpForce));
        }

        /// <summary>
        /// Allows the character to fire with a given weapon.
        /// </summary>
        /// <param name="weapon">The weapon to be used.</param>
        public void Fire(AWeapon weapon, PlatformerChar character)
        {
            // TODO
        }

        /// <summary>
        /// Allows the character to duck.
        /// </summary>
        public void Duck(PlatformerChar character)
        {
            // TODO
        }

        /// <summary>
        /// Allows the character to climb walls, ladders and so on.
        /// </summary>
        public void Climb(PlatformerChar character)
        {
            // TODO
        }
    }
}
