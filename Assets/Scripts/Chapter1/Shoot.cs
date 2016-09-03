using UnityEngine;
using System.Collections;

namespace Chapter1
{
	public class Shoot : MonoBehaviour
	{
		private float fireRate = .3f;
		private float nextFire = 0;
		private RaycastHit hit;
		private float range = 300;
		private Transform myTransform;

		// Use this for initialization
		void Start ()
		{
			SetInitialReferance ();
		}

		void SetInitialReferance ()
		{
			myTransform = transform;
		}

		// Update is called once per frame
		void Update ()
		{
			CheckForInput ();
		}

		void CheckForInput ()
		{
			if (Input.GetButton ("Fire1") && Time.time > nextFire) {

				Debug.DrawRay (myTransform.position, myTransform.forward, Color.green, 3f);
				if (Physics.Raycast (myTransform.position, myTransform.forward, out hit, range)) {
					if (hit.transform.CompareTag ("Enemy")) {
						//Debug.Log ("Enemy: " + hit.transform.name);
					} else {
						//Debug.Log ("Not an enemy");
					}
				}

				nextFire = Time.time + fireRate;
				//Debug.Log ("Key Pressed");
			} 
		}
	
	}
}