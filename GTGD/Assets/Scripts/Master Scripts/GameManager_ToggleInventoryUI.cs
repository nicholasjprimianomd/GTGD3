using UnityEngine;
using System.Collections;


namespace S3
{
	public class GameManager_ToggleInventoryUI : MonoBehaviour
	{
		[Tooltip ("Does this game mode have an inventory?")]
		public bool hasInventory;
		public GameObject inventoryUI;
		public string toggleInventoryButton;
		private GameManager_Master gameManagerMaster;


		void SetInitialReferances ()
		{
			gameManagerMaster = GetComponent<GameManager_Master> ();

			if (toggleInventoryButton == "") {
				Debug.LogWarning ("Please enter the name of the inventory toggle button in GameManager.");
				this.enabled = false;
			}
		}

		void CheckForInventoryToggleRequest ()
		{
			if (Input.GetButtonUp (toggleInventoryButton) && !gameManagerMaster.isMenuOn && !gameManagerMaster.isGameOver && hasInventory) {
				ToggleInventoryUI ();
			}
		}

		void ToggleInventoryUI ()
		{
			if (inventoryUI != null) {
				Debug.Log (inventoryUI.activeSelf);
				inventoryUI.SetActive (!inventoryUI.activeSelf);
				gameManagerMaster.isInventroyUIOn = !gameManagerMaster.isInventroyUIOn;
				gameManagerMaster.CallEventInventoryUI ();
			}
		}

		// Use this for initialization
		void Start ()
		{
			SetInitialReferances ();
		}
	
		// Update is called once per frame
		void Update ()
		{
			CheckForInventoryToggleRequest ();
		}
	}
}