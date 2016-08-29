using UnityEngine;
using System.Collections;

namespace Chapter1
{
	public class TriggerExample : MonoBehaviour
	{

		private EventMaster eventMasterScript;

		void SetInitalReferances ()
		{
			eventMasterScript = GameObject.Find ("GameManager").GetComponent<EventMaster> ();
		}

		void Start ()
		{
			SetInitalReferances ();
		}

		void OnTriggerEnter (Collider other)
		{

			eventMasterScript.CallMyGeneralEvent ();
			Destroy (gameObject);

		}
			
	}
}