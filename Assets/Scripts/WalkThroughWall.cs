using UnityEngine;
using System.Collections;

namespace Chapter1
{
	public class WalkThroughWall : MonoBehaviour
	{
        private Color myColor = new Color(.5f, 1f, 0.5f, .3f);

        public void SetLayerToNotSolid()
        {
           gameObject.layer = LayerMask.NameToLayer("NotSolid");
            GetComponent<Renderer>().material.SetColor("_Color", myColor);
       }

        public void SetLayerToDefault()
        {
            gameObject.layer = LayerMask.NameToLayer("Default");
            GetComponent<Renderer>().material.color = Color.white;
        }




    }
}