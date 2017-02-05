using UnityEngine;
using System.Collections;

namespace Chapter1
{
	public class WalkThroughWall : MonoBehaviour
	{


		void OnEnable ()
		{
			gameObject.layer = LayerMask.NameToLayer ("NotSolid");
		}

		void OnDisable ()
		{
			gameObject.layer = LayerMask.NameToLayer ("Default");
		}

	}
}