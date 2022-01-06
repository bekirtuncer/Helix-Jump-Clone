using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HelixJump.HelixManager
{
    public class HelixManager : MonoBehaviour
    {
        [SerializeField] private HelixManagerData _helixManagerData;
        
        public GameObject[] helixRings;

        public float ySpawn = 0;

        private void Start()
        {
            //spawn helix rings
            for (int i = 0; i < _helixManagerData.numberOfRings; i++)
            {
                if( i == 0)
                {
                    SpawnRing(0);
                }
                else
                {
                    SpawnRing(Random.Range(1, helixRings.Length - 1));
                } 
            }
            //spawn last ring
            SpawnRing(helixRings.Length - 1);
        }

        public void SpawnRing(int ringIndex)
        {
            GameObject go = Instantiate(helixRings[ringIndex], transform.up * ySpawn, Quaternion.identity);
            go.transform.parent = transform;
            ySpawn -= _helixManagerData.ringsDistance;
        }
    }    
}
