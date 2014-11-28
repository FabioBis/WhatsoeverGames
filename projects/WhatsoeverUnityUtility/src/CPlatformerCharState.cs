using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Whatsoever2DUnityUtility
{
    /// <summary>
    /// Singleton class for the standing state. The class can not be
    /// extended (selaed) and implemnts the Singleton and State pattern (GoF).
    /// </summary>
    public sealed class PlatformerStandingState : APlatformerCharState
    {
        private static PlatformerStandingState _instance;
        private static object _syncLock = new object();

        /// <summary>
        /// Private constructor (to avoid user to instantiate the class
        /// directly).
        /// </summary>
        private PlatformerStandingState() { }


        /// <summary>
        /// Public static instance for the standing state class.
        /// </summary>
        public static PlatformerStandingState Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new PlatformerStandingState();
                        }
                    } // End Lock.
                }
                return _instance;
            }
        }

        // Move, Jump, Fire, Duck, Climb methods are inherited from
        // abstract class. Standing state implements the default behaviour.
    }

    /// <summary>
    /// Singleton class for the dead state. The class can not be
    /// extended (selaed) and implemnts the Singleton and State pattern (GoF).
    /// </summary>
    public sealed class PlatformerDeadState : APlatformerCharState
    {
        private static PlatformerDeadState _instance;
        private static object _syncLock = new object();

        /// <summary>
        /// Private constructor (to avoid user to instantiate the class
        /// directly).
        /// </summary>
        private PlatformerDeadState() { }


        /// <summary>
        /// Public static instance for the standing state class.
        /// </summary>
        public static PlatformerDeadState Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new PlatformerDeadState();
                        }
                    } // End Lock.
                }
                return _instance;
            }
        }

        public override void Move(float hspace, PlatformerChar character)
        {
            // Dead character does not move.
            ;
        }

        public override void Jump(PlatformerChar character)
        {
            // Dead character does not jump.
            ;
        }

        public override void Fire(AWeapon weapon, PlatformerChar character)
        {
            // Dead character does not fire.
            ;
        }

        public override void Duck(PlatformerChar character)
        {
            // Dead character does not duck.
            ;
        }

        public override void Climb(PlatformerChar character)
        {
            // Dead character does not climb.
            ;
        }
    }

    /// <summary>
    /// Singleton class for the jumping state. The class can not be
    /// extended (selaed) and implemnts the Singleton and State pattern (GoF).
    /// </summary>
    public sealed class PlatformerJumpingState : APlatformerCharState
    {
        private static PlatformerJumpingState _instance;
        private static object _syncLock = new object();

        /// <summary>
        /// Private constructor (to avoid user to instantiate the class
        /// directly).
        /// </summary>
        private PlatformerJumpingState() { }


        /// <summary>
        /// Public static instance for the standing state class.
        /// </summary>
        public static PlatformerJumpingState Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new PlatformerJumpingState();
                        }
                    } // End Lock.
                }
                return _instance;
            }
        }

        public override void Move(float hspace, PlatformerChar character)
        {
            // TODO
            ;
        }

        public override void Jump(PlatformerChar character)
        {
            // Avoid to jump over and over.
            ;
        }

        // Default Fireing.
        //public override void Fire(AWeapon weapon, PlatformerChar character)
        //{
        //    ;
        //}

        public override void Duck(PlatformerChar character)
        {
            // Avoid to duck while jumping.
            ;
        }

        public override void Climb(PlatformerChar character)
        {
            // TODO: grab the ladder (or whatever) to start climbing.
            ;
        }
    }

    /// <summary>
    /// Singleton class for the ducking state. The class can not be
    /// extended (selaed) and implemnts the Singleton and State pattern (GoF).
    /// </summary>
    public sealed class PlatformerDuckingState : APlatformerCharState
    {
        private static PlatformerDuckingState _instance;
        private static object _syncLock = new object();

        /// <summary>
        /// Private constructor (to avoid user to instantiate the class
        /// directly).
        /// </summary>
        private PlatformerDuckingState() { }


        /// <summary>
        /// Public static instance for the standing state class.
        /// </summary>
        public static PlatformerDuckingState Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new PlatformerDuckingState();
                        }
                    } // End Lock.
                }
                return _instance;
            }
        }

        public override void Move(float hspace, PlatformerChar character)
        {
            // TODO: move at reduced speed.
            ;
        }

        public override void Jump(PlatformerChar character)
        {
            // Avoid to jump while ducking.
            ;
        }

        public override void Fire(AWeapon weapon, PlatformerChar character)
        {
            // Avoid to fire while ducking.
            ;
        }

        public override void Duck(PlatformerChar character)
        {
            // Character is already ducking!
            ;
        }

        public override void Climb(PlatformerChar character)
        {
            // TODO.
            ;
        }
    }

    /// <summary>
    /// Singleton class for the climbing state. The class can not be
    /// extended (selaed) and implemnts the Singleton and State pattern (GoF).
    /// </summary>
    public sealed class PlatformerClimbingState : APlatformerCharState
    {
        private static PlatformerClimbingState _instance;
        private static object _syncLock = new object();

        /// <summary>
        /// Private constructor (to avoid user to instantiate the class
        /// directly).
        /// </summary>
        private PlatformerClimbingState() { }


        /// <summary>
        /// Public static instance for the standing state class.
        /// </summary>
        public static PlatformerClimbingState Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new PlatformerClimbingState();
                        }
                    } // End Lock.
                }
                return _instance;
            }
        }

        public override void Move(float hspace, PlatformerChar character)
        {
            // TODO: move at reduced speed.
            ;
        }

        public override void Jump(PlatformerChar character)
        {
            // Avoid to jump while ducking.
            ;
        }

        public override void Fire(AWeapon weapon, PlatformerChar character)
        {
            // Avoid to fire while ducking.
            ;
        }

        public override void Duck(PlatformerChar character)
        {
            // Character is already ducking!
            ;
        }

        public override void Climb(PlatformerChar character)
        {
            // TODO.
            ;
        }
    }

    /// <summary>
    /// Singleton class for the falling state. The class can not be
    /// extended (selaed) and implemnts the Singleton and State pattern (GoF).
    /// </summary>
    public sealed class PlatformerFallingState : APlatformerCharState
    {
        private static PlatformerFallingState _instance;
        private static object _syncLock = new object();

        /// <summary>
        /// Private constructor (to avoid user to instantiate the class
        /// directly).
        /// </summary>
        private PlatformerFallingState() { }


        /// <summary>
        /// Public static instance for the Falling state class.
        /// </summary>
        public static PlatformerFallingState Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new PlatformerFallingState();
                        }
                    } // End Lock.
                }
                return _instance;
            }
        }

        public override void Move(float hspace, PlatformerChar character)
        {
            // TODO
            ;
        }

        public override void Jump(PlatformerChar character)
        {
            // Avoid to jump while falling.
            ;
        }

        // Default Fireing.
        //public override void Fire(AWeapon weapon, PlatformerChar character)
        //{
        //    ;
        //}

        public override void Duck(PlatformerChar character)
        {
            // Avoid to duck while falling.
            ;
        }

        public override void Climb(PlatformerChar character)
        {
            // TODO: grab the ladder (or whatever) to start climbing.
            ;
        }
    }
}