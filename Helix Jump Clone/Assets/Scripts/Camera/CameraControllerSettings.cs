using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HelixJump.CameraControls
{
    [CreateAssetMenu(menuName = "HelixJump/Camera/CameraSettings")]
    public class CameraControllerSettings : ScriptableObject
    {
        public Vector3 cameraOffset;
        public float lerpSpeed;
    }
}
