using UnityEngine;
using System.Collections;

namespace S3
{
	public class GameManager_TogglePause : MonoBehaviour
	{
		private GameManager_Master gameManagerMaster;

		private bool isPaused;

		void OnEnable ()
		{
			SetInitialReferances ();
			gameManagerMaster.MenuToggleEvent += TogglePause;
			gameManagerMaster.InventoryUIToggleEvent += TogglePause;
		}

		void OnDisable ()
		{
			gameManagerMaster.MenuToggleEvent -= TogglePause;
			gameManagerMaster.InventoryUIToggleEvent -= TogglePause;
		}

		void SetInitialReferances ()
		{
			gameManagerMaster = GetComponent<GameManager_Master> ();
		}

		void TogglePause ()
		{
			if (isPaused) {
				Time.timeScale = 1;
				isPaused = false;
			} else {
				Time.timeScale = 0;
				isPaused = true;
			}
		}
			
	}
}