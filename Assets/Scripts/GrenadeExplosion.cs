using UnityEngine;
using System.Collections;


namespace Chapter1
{
	public class GrenadeExplosion : MonoBehaviour
	{

		private Collider[] hitColliders;
		public float blastRadius;
		public float explosionPower;
		public LayerMask explosionLayers;

		void ExplosionWork (Vector3 explosionPoint)
		{
			hitColliders = Physics.OverlapSphere (explosionPoint, blastRadius, explosionLayers);

			foreach (Collider hitCol in hitColliders) {
				Debug.Log ("Hit: " + hitCol.gameObject.name);
				if (hitCol.GetComponent<Rigidbody> () != null) {
					hitCol.GetComponent<Rigidbody> ().isKinematic = false;
					hitCol.GetComponent<Rigidbody> ().AddExplosionForce (explosionPower, explosionPoint, blastRadius, 1f, ForceMode.Impulse);
				}

			}
		}


		void OnCollisionEnter (Collision col)
		{
			//Debug.Log(col.contacts[0].point.ToString());
			ExplosionWork (col.contacts [0].point);
			Destroy (gameObject);  
		}
	}
}