using UnityEngine;
using System.Collections;

namespace S3
{
	public class GameManager_ToggleMenu : MonoBehaviour
	{
		private GameManager_Master gameManageMaster;
		public GameObject menu;

		void OnEnable ()
		{
			SetInitialReferances ();
			gameManageMaster.GameOverEvent += ToggleMenu;
		}

		void OnDisable ()
		{
			gameManageMaster.GameOverEvent -= ToggleMenu;
		}

		void CheckForMenuToggleRequest ()
		{
			if (Input.GetKeyUp (KeyCode.Escape) && !gameManageMaster.isGameOver && !gameManageMaster.isInventroyUIOn) {
				ToggleMenu ();	
			}
		}

		void SetInitialReferances ()
		{
			gameManageMaster = GetComponent<GameManager_Master> ();
		}

		void ToggleMenu ()
		{
			if (menu != null) {
				menu.SetActive (!menu.activeSelf);
				gameManageMaster.isMenuOn = !gameManageMaster;
				gameManageMaster.CallEventMenuToggle ();	
			} else {
				Debug.LogWarning ("Assign a UI game object to the ToggleMenu script in the inspector.");
			}
		}
		// Use this for initialization
		void Start ()
		{
			ToggleMenu ();
		}
	
		// Update is called once per frame
		void Update ()
		{
			CheckForMenuToggleRequest ();
		}
	}
}