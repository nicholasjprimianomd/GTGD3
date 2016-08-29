using UnityEngine;
using System.Collections;
using UnityEngine.SocialPlatforms;
using System.Collections.Generic;

namespace Chapter1
{
	public class Spawner : MonoBehaviour
	{
		public int numberOfEnemies;
		public GameObject objectToSpawn;
		private float spawnRadius = 5;
		private Vector3 spawnPosition;
		private EventMaster eventMasterScript;

		void OnEnable ()
		{
			SetInitalReferances ();
			eventMasterScript.myGeneralEvent += SpawnObject;
		}

		void OnDisable ()
		{
			eventMasterScript.myGeneralEvent -= SpawnObject;
		}

		void SetInitalReferances ()
		{
			eventMasterScript = GameObject.Find ("GameManager").GetComponent<EventMaster> ();
		}

		// Use this for initialization
		void Start ()
		{
			//SpawnObject ();
		}


		void SpawnObject ()
		{
			for (int i = 0; i < numberOfEnemies; i++) {
				spawnPosition = transform.position + Random.insideUnitSphere * spawnRadius;
				Instantiate (objectToSpawn, spawnPosition, Quaternion.identity);
			}
		}

	}
}