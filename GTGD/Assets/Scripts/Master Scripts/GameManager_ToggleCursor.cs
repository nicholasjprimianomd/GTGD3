﻿using UnityEngine;
using System.Collections;


namespace S3
{
	public class GameManager_ToggleCursor : MonoBehaviour
	{
		private GameManager_Master gameManagerMaster;
		private bool isCursorLocked = true;

		void OnEnable ()
		{
			SetInitialReferances ();
			gameManagerMaster.MenuToggleEvent += ToggleCursorState;
			gameManagerMaster.InventoryUIToggleEvent += ToggleCursorState;
		}

		void OnDisable ()
		{
			gameManagerMaster.MenuToggleEvent -= ToggleCursorState;
			gameManagerMaster.InventoryUIToggleEvent -= ToggleCursorState;
		}

		void SetInitialReferances ()
		{
			gameManagerMaster = GetComponent<GameManager_Master> ();
		}

		void ToggleCursorState ()
		{
			isCursorLocked = !isCursorLocked; 
		}

		void CheckIfCursorShouldBeLocked ()
		{
			if (isCursorLocked) {
				Cursor.lockState = CursorLockMode.Locked;
				Cursor.visible = false;
			} else {
				Cursor.lockState = CursorLockMode.None;
				Cursor.visible = true;	
			}
		}

		void Update ()
		{
			CheckIfCursorShouldBeLocked ();			
		}

	}
}