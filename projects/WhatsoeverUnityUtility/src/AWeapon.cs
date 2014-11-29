using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Whatsoever2DUnityUtility
{
    /// <summary>
    /// This class represents an abstraction of a weapon. The
    /// responsability of a derived class is to implement the behaviour of
    /// a specific weapon. This class can not be instantiated, but 
    /// subclassed.
    /// </summary>
    public abstract class AWeapon
    {
        // The damage per hit of the weapon.
        private uint damage;
        // The powerups applied to a weapon, if any.
        private APowerUp powerup = null;


        /// <summary>
        /// Protected constructor, instance this class directly is not allowed.
        /// </summary>
        protected AWeapon(uint dmg, APowerUp pwup = null)
        {
            this.damage = dmg;
            this.powerup = pwup;
        }

        /// <summary>
        /// Update the damage value.
        /// </summary>
        /// <param name="dmg">
        /// The new damage value.
        /// </param>
        protected void setDamage(uint dmg)
        {
            this.damage = dmg;
        }

        /// <summary>
        /// Getter method for damage value.
        /// </summary>
        protected uint getDamage()
        {
            return this.damage;
        }

        /// <summary>
        /// Set a new powerup to the weapon.
        /// </summary>
        /// <param name="pwup">
        /// The new powerup.
        /// </param>
        protected void setPowerUp(APowerUp pwup)
        {
            this.powerup = pwup;
        }

        /// <summary>
        /// Getter method for the powerup.
        /// </summary>
        protected APowerUp getPowerUp()
        {
            return this.powerup;
        }

        // TODO.
        abstract public void Fire();
        // TODO.
        abstract public void AddPowerUp(APowerUp pwup);
    }
}
