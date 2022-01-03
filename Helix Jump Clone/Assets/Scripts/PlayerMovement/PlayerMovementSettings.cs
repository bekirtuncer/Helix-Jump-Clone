using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HelixJump.PlayerControls
{
    [CreateAssetMenu(menuName = "HelixJump/Player/MovementSettings")]
    public class PlayerMovementSettings : ScriptableObject
    {
        public float jumpForce = 5f;
    }
}
