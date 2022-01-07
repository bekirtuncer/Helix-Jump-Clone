using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HelixJump
{
    public class RingData : MonoBehaviour
    {
        private Transform player;
        // Start is called before the first frame update
        void Start()
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }

        // Update is called once per frame
        void Update()
        {
            if(transform.position.y > player.position.y)
            {
                GameManager.numberOfPassedRings++;
                Destroy(gameObject);
            }
        }
    }
}
