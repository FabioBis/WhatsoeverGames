

namespace Whatsoever2DUnityUtility
{
    /// <summary>
    /// This class implements the player control manager for a platformer
    /// game.
    /// </summary>
    public class PlayerPlatformerCOntrol : IPlatformerControl
    {
        /// <summary>
        /// Let the player move.
        /// </summary>
        /// <param name="state">
        /// The player state (standing, jumping, ...).
        /// </param>
        /// <param name="platformerChar">
        /// The player character.
        /// </param>
        /// <param name="horizontal">
        /// The amount of distance covered in a frame.
        /// </param>
        public void Move(APlatformerCharState state,
            PlatformerChar platformerChar, float horizontal)
        {
            state.Move(horizontal, platformerChar);
        }

        /// <summary>
        /// Let the player jump.
        /// </summary>
        /// <param name="state">
        /// The player state (standing, jumping, ...).
        /// </param>
        /// <param name="platformerChar">
        /// The player character.
        /// </param>
        public void Jump(APlatformerCharState state,
            PlatformerChar platformerChar)
        {
            state.Jump(platformerChar);
        }

        /// <summary>
        /// Let the player use a given weapn.
        /// </summary>
        /// <param name="state">
        /// The player state (standing, jumping, ...).
        /// </param>
        /// <param name="platformerChar">
        /// The player character.
        /// </param>
        /// <param name="weapon">
        /// The weapon used.
        /// </param>
        public void Fire(APlatformerCharState state,
            PlatformerChar platformerChar, AWeapon weapon)
        {
            state.Fire(weapon, platformerChar);
        }

        /// <summary>
        /// Let the player duck.
        /// </summary>
        /// <param name="state">
        /// The player state (standing, jumping, ...).
        /// </param>
        /// <param name="platformerChar">
        /// The player character.
        /// </param>
        public void Duck(APlatformerCharState state,
            PlatformerChar platformerChar)
        {
            state.Duck(platformerChar);
        }

        /// <summary>
        /// Let the player climb.
        /// </summary>
        /// <param name="state">
        /// The player state (standing, jumping, ...).
        /// </param>
        /// <param name="platformerChar">
        /// The player character.
        /// </param>
        public void Climb(APlatformerCharState state,
            PlatformerChar platformerChar)
        {
            throw new System.NotImplementedException();
        }

    }
}