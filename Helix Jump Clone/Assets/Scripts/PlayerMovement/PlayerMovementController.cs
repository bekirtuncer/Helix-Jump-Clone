using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HelixJump.PlayerControls
{
    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rb;
        [SerializeField] private PlayerMovementSettings _playerMovementSettings;

        private void OnCollisionEnter(Collision collision)
        {
            _rb.velocity = new Vector3(_rb.velocity.x, _playerMovementSettings.jumpForce, _rb.velocity.z);
        }
    }
}
