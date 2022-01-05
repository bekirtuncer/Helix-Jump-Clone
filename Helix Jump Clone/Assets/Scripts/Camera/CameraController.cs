using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HelixJump.CameraControls
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private CameraControllerSettings _cameraControllerSettings;

        public Transform target;
        private void Start()
        {
            _cameraControllerSettings.cameraOffset = transform.position - target.position;
        }

        private void LateUpdate()
        {
            Vector3 newPos = Vector3.Lerp(transform.position, target.position + _cameraControllerSettings.cameraOffset, _cameraControllerSettings.lerpSpeed);
            transform.position = newPos;
        }
    }
}
