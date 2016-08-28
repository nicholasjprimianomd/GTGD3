using UnityEngine;
using System.Collections;

namespace Chapter1
{
    public class TriggerExample : MonoBehaviour
    {
        private WalkThroughWall walkThroughWall;

        void SetInitalReferances()
        {
            if (GameObject.Find("Wall") != null)
            {
                walkThroughWall = GameObject.Find("Wall").GetComponent<WalkThroughWall>();
            }
        }
        
        void Start()
        {
            SetInitalReferances();
        }
           
        void OnTriggerEnter(Collider other)
        {
            walkThroughWall.SetLayerToNotSolid();

            //Debug.Log(other.name + " has entered" );
        }

        void OnTriggerExit(Collider other)
        {
            walkThroughWall.SetLayerToDefault();

            //Debug.Log(other.name + " has exited");
        }

        void OnTriggerStay(Collider other)
        {
            //Debug.Log(other.name + " has stayed");
        }
    }
}