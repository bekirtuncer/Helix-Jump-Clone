using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HelixJump
{
    [CreateAssetMenu(menuName = "HelixJump/HelixManager/HelixManagerData")]
    public class HelixManagerData : ScriptableObject
    {
        public float ringsDistance = 5;

        public int numberOfRings;
    }

}
