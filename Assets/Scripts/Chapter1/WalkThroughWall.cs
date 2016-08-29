using UnityEngine;
using System.Collections;

namespace Chapter1
{
	public class WalkThroughWall : MonoBehaviour
	{
		private Color myColor = new Color (.5f, 1f, 0.5f, .3f);
		private EventMaster eventMasterScript;

		void SetLayerToNotSolid ()
		{
			gameObject.layer = LayerMask.NameToLayer ("NotSolid");
			GetComponent<Renderer> ().material.SetColor ("_Color", myColor);
		}

		void OnEnable ()
		{
			SetInitialRenferances ();
			eventMasterScript.myGeneralEvent += SetLayerToNotSolid;
		}

		void OnDisable ()
		{
			eventMasterScript.myGeneralEvent -= SetLayerToNotSolid;
		}

		void SetInitialRenferances ()
		{
			eventMasterScript = GameObject.Find ("GameManager").GetComponent<EventMaster> ();
		}

	}
}