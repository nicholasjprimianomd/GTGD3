using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;

public class IntroText : MonoBehaviour
{

	private Text introText;

	// Use this for initialization
	void Start ()
	{
		introText = GetComponent<Text> ();
		introText.text = "Treasure Awaits";

		Invoke ("HideText", 3f);
	}

	void HideText ()
	{
		introText.text = "";
		GameObject.Find ("Panel").SetActive (false);
	}

}
