using UnityEngine;
using System.Collections;
namespace Chapter1
{
    public class ThrowGrenade : MonoBehaviour
    {

        public GameObject grenadePrefab;
        private Transform myTransform;
        public float propultionForce;

        // Use this for initialization
        void Start()
        {
            SetInitialReferances();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                SpawnGrenade();
            }
        }

        void SpawnGrenade()
        {
            GameObject go = (GameObject) Instantiate(grenadePrefab, myTransform.TransformPoint(0f,0f,.1f), myTransform.rotation);
            go.GetComponent<Rigidbody>().AddForce(myTransform.forward * propultionForce, ForceMode.Impulse);
            Destroy(go,10f);
        }

        void SetInitialReferances()
        {
            myTransform = transform;
        }
    }
}