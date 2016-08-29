using UnityEngine;
using System.Collections;

namespace Chapter1
{
	public class TriggerExample : MonoBehaviour
	{
		private WalkThroughWall walkThroughWall;
		private EventMaster eventMasterScript;

		void SetInitalReferances ()
		{
			if (GameObject.Find ("Wall") != null) {
				walkThroughWall = GameObject.Find ("Wall").GetComponent<WalkThroughWall> ();
				eventMasterScript = GameObject.Find ("GameManager").GetComponent<EventMaster> ();
			}
		}

		void Start ()
		{
			SetInitalReferances ();
		}

		void OnTriggerEnter (Collider other)
		{
			walkThroughWall.SetLayerToNotSolid ();
			eventMasterScript.CallMyGeneralEvent ();

			//Debug.Log(other.name + " has entered" );
		}

		void OnTriggerExit (Collider other)
		{
			walkThroughWall.SetLayerToDefault ();

			//Debug.Log(other.name + " has exited");
		}

		void OnTriggerStay (Collider other)
		{
			//Debug.Log(other.name + " has stayed");
		}
	}
}