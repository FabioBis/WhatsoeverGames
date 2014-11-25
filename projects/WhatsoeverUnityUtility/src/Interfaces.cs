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
}
