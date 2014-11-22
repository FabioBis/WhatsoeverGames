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
        /// TODO
        /// </summary>
        /// <param name="horizontal"></param>
        public void Move(float horizontal)
        {
            // TODO
        }

        /// <summary>
        /// TODO
        /// </summary>
        public void Jump()
        {
            // TODO
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="weapon"></param>
        public void Fire(IWeapon weapon)
        {
            // TODO
        }

        /// <summary>
        /// TODO
        /// </summary>
        public void Duck()
        { 
            // TODO
        }

        /// <summary>
        /// TODO
        /// </summary>
        public void Climb()
        {
            // TODO
        }

        /// <summary>
        /// TODO
        /// </summary>
        protected void flip()
        { 
            // TODO
        }
    }
}
