
namespace Whatsoever2DUnityUtility
{
    /// <summary>
    /// This class represents an abstraction of a powerup. The
    /// responsability of a derived class is to implement the behaviour of
    /// a specific powerup. This class can not be instantiated, but 
    /// subclassed.
    /// </summary>
    public class APowerUp
    {
        // The damage modification (could be less than zero).
        abstract private int damageBoost;
        // The ammo left until the boost is consumed (-1 if infty ammo).
        abstract private int ammo;

        /// <summary>
        /// Protected constructor, instance this class directly is not allowed.
        /// </summary>
        protected APowerUp(int dmg, int ammo)
        {
            this.damageBoost = dmg;
            this.ammo = ammo;
        }

        /// <summary>
        /// This method decrease ammo counter by 1.
        /// </summary>
        public void AmmoConsumed()
        {
            if (ammo > 0)
            {
                // Ammo are not infty (-1) nor all consumed (0).
                ammo--;
            }
        }

        /// <summary>
        /// Returns true if the powerup is consumed.
        /// </summary>
        public bool OutOfAmmo()
        {
            // The power up is consumed when ammo decrease to 0.
            return ammo == 0;
        }

        /// <summary>
        /// Modifies the given amount of damage of a weapon.
        /// </summary>
        /// <param name="damage"></param>
        public void ApplyBoost(ref uint damage)
        {
            long dmg = damage;
            dmg += damageBoost;
            if (dmg > 0)
            {
                damage = (uint)dmg;                
            }
        }
    }
}
