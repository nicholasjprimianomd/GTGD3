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
		private float spawnRadius;
		private Vector3 spawnPosition;

		// Use this for initialization
		void Start ()
		{
			SpawnObject ();
		}
	
		// Update is called once per frame
		void Update ()
		{
	
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