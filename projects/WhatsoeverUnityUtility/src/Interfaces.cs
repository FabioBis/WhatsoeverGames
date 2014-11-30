using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Whatsoever2DUnityUtility
{
    public interface ICollectable 
    {
        void OnTriggerEnter2D(Collider2D collider); 
    }

    public interface IPlatformerCollector
    {
        public void UpdateHealt(int h);
        public void UpdatePrimaryWeapon(AWeapon wpn);
        public void UpdateSecondaryWeapon(AWeapon wpn);
        public void UpdateMaxSpeed(float variation, int time);
        public void UpdateJumpForce(float variation, int time);
    }

    public interface IPlatformerControl
    {
        public void Move(APlatformerCharState state,
            PlatformerChar platformerChar, float horizontal);
        void Jump(APlatformerCharState state, PlatformerChar platformerChar);
        void Fire(APlatformerCharState state,
            PlatformerChar platformerChar, AWeapon weapon);
        void Duck(APlatformerCharState state, PlatformerChar platformerChar);
        void Climb(APlatformerCharState state, PlatformerChar platformerChar);
    }
}
