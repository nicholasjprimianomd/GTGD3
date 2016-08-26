using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Reflection.Emit;
using System.Collections.Generic;
using System.Threading;

namespace Chapter1
{
	public class Welcome : MonoBehaviour
	{
		public string myMessage = "Welcome";
		public GameObject canvasWelcome;
		private Text textWelcome;
		private float waitTime = 3.5f;

		void Start ()
		{
			SetInitialReferances ();
			MyWelcomeMessage ();
		}

		void SetInitialReferances ()
		{
			textWelcome = GameObject.Find ("TextWelcome").GetComponent<Text> ();
		}

		void MyWelcomeMessage ()
		{
			if (textWelcome != null) {
				textWelcome.text = myMessage;
			} else {
				Debug.Log ("textWelcome not assigned");
			}
		
			StartCoroutine (DisableCanvas (waitTime));
		}



		IEnumerator DisableCanvas (float waitTime)
		{
			yield return new WaitForSeconds (waitTime);
			canvasWelcome.SetActive (false);
		}

	}
}