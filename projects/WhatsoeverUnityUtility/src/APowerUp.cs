
namespace Whatsoever2DUnityUtility
{
    /// <summary>
    /// This class represents an abstraction of a powerup. The
    /// responsability of a derived class is to implement the behaviour of
    /// a specific powerup. This class can not be instantiated, but 
    /// subclassed.
    /// </summary>
    public abstract class APowerUp
    {
        // The damage modification (could be less than zero).
        abstract private int damageBoost;
        // The ammo left until the boost is consumed (-1 if infty ammo).
        abstract private int charges;

        /// <summary>
        /// Protected constructor, instance this class directly is not allowed.
        /// </summary>
        protected APowerUp(int dmg, int ammo)
        {
            this.damageBoost = dmg;
            this.charges = ammo;
        }

        /// <summary>
        /// This method decrease ammo counter by 1.
        /// </summary>
        public void AmmoConsumed()
        {
            if (charges > 0)
            {
                // Ammo are not infty (-1) nor all consumed (0).
                charges--;
            }
        }

        /// <summary>
        /// Returns true if the powerup is consumed.
        /// </summary>
        public bool OutOfCharges()
        {
            // The power up is consumed when ammo decrease to 0.
            return charges == 0;
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
            else
            {
                // Do nothing, damage not changed.
                ;
            }
        }
    }
}
