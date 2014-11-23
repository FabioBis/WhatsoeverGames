using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace WhatsoeverUnityUtility
{
    /// <summary>
    /// This class represents an abstraction of what state a character could
    /// be (state machine). See State Pattern.
    /// </summary>
    abstract public class ACharacter2DState
    {
        // Is the character facing right?
        private bool facingRight;
        // The maximum speed the character can reach.
        private float maxSpeed;
        // The force applied to character while moving (acceleration).
        private float moveForce;
        // The force applied to character while jumping (deceleration).
        private float jumpForce;

        // The character rigidbody.
        private Rigidbody2D rigidbody;

        /// <summary>
        /// Allows the character to move horizontally.
        /// </summary>
        /// <param name="horizontal">
        /// The amount of movement for the current frame.
        /// </param>
        public void Move(float horizontal)
        {
            if (rigidbody == null)
            {
                throw new NullReferenceException();
            }
            if (horizontal * rigidbody.velocity.x < maxSpeed)
            {
                // The character is changing direction (horizontal has a
                // different sign to velocity.x) or hasn't reached maxSpeed.
                // Add a force to the player.
                rigidbody.AddForce(Vector2.right * horizontal * moveForce);
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
            if ((horizontal > 0 && !facingRight) ||
                (horizontal < 0 && facingRight))
            {
                // The character changed direction.
                flip();
            }
        }

        /// <summary>
        /// Allows the character to jump.
        /// </summary>
        public void Jump()
        {
            if (rigidbody == null)
            {
                throw new NullReferenceException();
            }
            // Add a vertical force to the player.
            rigidbody.AddForce(new Vector2(0f, jumpForce));
        }

        /// <summary>
        /// Allows the character to fire with a given weapon.
        /// </summary>
        /// <param name="weapon">The weapon to be used.</param>
        public void Fire(IWeapon weapon)
        {
            // TODO
        }

        /// <summary>
        /// Allows the character to duck.
        /// </summary>
        public void Duck()
        { 
            // TODO
        }

        /// <summary>
        /// Allows the character to climb walls, ladders and so on.
        /// </summary>
        public void Climb()
        {
            // TODO
        }

        /// <summary>
        /// Allows the character to turn.
        /// </summary>
        protected void flip()
        {
            if (rigidbody == null)
            {
                throw new NullReferenceException();
            }
            // Switch the way the player is labelled as facing.
            facingRight = !facingRight;

            Transform transform =
                rigidbody.GetComponentInParent<Transform>();
            // Multiply the player's x local scale by -1.
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
    }
}
