using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HelixJump.TowerControls
{ 
    public class TowerRotationController : MonoBehaviour
    {
        [SerializeField] private TowerRotationSettings _towerRotationSettings;
        private void Update()
        {
            TowerRotate();
        }

        private void TowerRotate()
        {
            if (Input.GetMouseButton(0))
            {
                float mouseX = Input.GetAxisRaw("Mouse X");
                transform.Rotate(0, -mouseX * _towerRotationSettings.rotationSpeed * Time.deltaTime, 0);
            }
        }
    }
}
