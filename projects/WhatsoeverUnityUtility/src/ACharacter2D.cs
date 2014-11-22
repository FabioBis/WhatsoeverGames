using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhatsoeverUnityUtility
{
    /// <summary>
    /// This class represents an abstraction of what a character is within
    /// the Unity environment. To use this class correctly each Unity script
    /// attached to a character (that implements it) must extends this class.
    /// </summary>
    abstract public class ACharacter2D
    {
        // The current character healt.
        public int Healt;
        // The maximum speed the character can reach.
        public float MaxSpeed;
        // The force applied to character while moving (acceleration).
        public float MoveForce;
        // The force applied to character while jumping (deceleration).
        public float JumpForce;

        // The character current state (Standing, Jumping, ...).
        protected ACharacter2DState state;
        // The character control manager (Move, Jump, ...).
        protected AControlManager controlManager;

        /// <summary>
        /// This method must be overidden by concrete classes, it is mandatory
        /// to initialize the state variable. Call this method inside Awake or
        /// Start Unity event.
        /// </summary>
        abstract protected void initState();

        /// <summary>
        /// This method must be overidden by concrete classes, it is mandatory
        /// to initialize the controlManager variable. Call this method inside
        /// Awake or Start Unity event.
        /// </summary>
        abstract protected void initControlManager();
    }
}
