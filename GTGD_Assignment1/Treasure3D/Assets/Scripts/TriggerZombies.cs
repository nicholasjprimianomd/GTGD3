using UnityEngine;
using System.Collections;

public class TriggerZombies : MonoBehaviour
{

	private EventMaster eventMasterScript;

	void SetInitalReferances ()
	{
		eventMasterScript = GameObject.Find ("Game Manager").GetComponent<EventMaster> ();
	}

	void Start ()
	{
		SetInitalReferances ();
	}

	void OnTriggerEnter (Collider other)
	{
		Debug.Log (other.tag);
		if (other.CompareTag ("Player")) {
			eventMasterScript.CallMyGeneralEvent ();
			Destroy (gameObject);
		}
	}

}

