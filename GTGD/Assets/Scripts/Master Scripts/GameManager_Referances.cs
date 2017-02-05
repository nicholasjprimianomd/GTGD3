using UnityEngine;
using System.Collections;

namespace S3
{
	public class GameManager_Referances : MonoBehaviour
	{
		public string playerTag;
		public static string _playerTag;
		public string enemyTag;
		public static string _enemyTag;
		public static Object _player;

		void OnEnable ()
		{
			if (playerTag == "") {
				Debug.LogWarning ("Please enter a player tag in the inspector.");
			}

			if (enemyTag == "") {
				Debug.LogWarning ("Please enter an enemy tag in the inspector.");
			}

			_playerTag = playerTag;
			_enemyTag = enemyTag;
			_player = GameObject.FindGameObjectWithTag ("Player");
		}

		void OnDisable ()
		{
			
		}

		void SetInitialReferances ()
		{
			
		}

	}
}