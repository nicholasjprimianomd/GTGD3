using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace Chapter1
{
	public class Detection : MonoBehaviour
	{
		private RaycastHit hit;
		private float checkRate = .5f;
		private float nextCheck;
		[SerializeField]private LayerMask detectionLayer;
		private Transform myTransform;
		private float range = 5f;

		void SetInitalReferances ()
		{
			myTransform = transform;
			detectionLayer = 1 << 9;
		}

		// Use this for initialization
		void Start ()
		{
			SetInitalReferances ();
		}
	
		// Update is called once per frame
		void Update ()
		{
			DetectItems ();
		}

		void DetectItems ()
		{
			if (Time.time > nextCheck) {
				nextCheck = Time.time + checkRate;

				if (Physics.Raycast (myTransform.position, myTransform.forward, out hit, range, detectionLayer)) {
					Debug.Log (hit.transform.name + " is an item");
				}
			}
		}
	}
}