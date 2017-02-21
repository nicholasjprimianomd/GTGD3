using UnityEngine;
using System.Collections;


public class EventMaster : MonoBehaviour
{
	public delegate void GeneralEvent ();

	public event GeneralEvent myGeneralEvent;

	public void CallMyGeneralEvent ()
	{
		if (myGeneralEvent != null) {
			myGeneralEvent ();
		}
	}

}