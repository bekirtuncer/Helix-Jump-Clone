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
            string materialName = collision.transform.GetComponent<MeshRenderer>().material.name;

            if(materialName == "Safe (Instance)")
            {

            }
            else if(materialName == "Unsafe (Instance)")
            {
                GameManager.gameOver = true;
            }
            else if ( materialName == "LastRing (Instance)")
            {
                GameManager.levelCompleted = true;
            }
        }
    }
}
