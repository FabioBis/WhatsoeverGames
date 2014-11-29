using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Whatsoever2DUnityUtility
{
    public interface ICollectable 
    {
        public void Collected(MonoBehaviour characterScript);
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
