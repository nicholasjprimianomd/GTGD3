using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

namespace S3
{
	public class GameManager_TogglePlayer : MonoBehaviour
	{

		public FirstPersonController playerController;
		private GameManager_Master gameManagerMaster;

		void OnEnable ()
		{
			SetInitialReferaneces ();
			gameManagerMaster.MenuToggleEvent += TogglePlayerController;
			gameManagerMaster.InventoryUIToggleEvent += TogglePlayerController;
		}

		void OnDisable ()
		{
			gameManagerMaster.MenuToggleEvent -= TogglePlayerController;
			gameManagerMaster.InventoryUIToggleEvent -= TogglePlayerController;
		}

		void SetInitialReferaneces ()
		{
			gameManagerMaster = GetComponent<GameManager_Master> ();
		}

		void TogglePlayerController ()
		{
			if (playerController != null) {
				playerController.enabled = !playerController.enabled;
			}
		}


	}
}