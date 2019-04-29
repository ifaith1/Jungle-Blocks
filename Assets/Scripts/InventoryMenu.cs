using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryMenu : MonoBehaviour
{
    private static InventoryMenu instance;
    private CanvasGroup canvasGroup;

    public static InventoryMenu Instance
    {
        get
        {
            if (instance == null)
                throw new System.Exception("There is currently no InventoryMenu instance, " +
                    "But you are trying to access it! Makesure the InventoryMenu script is applied to a GameObjectin your scene!");
            return instance;
        }
        private set { instance = value; }
    }

    private bool isVisible => canvasGroup.alpha > 0;


    private void ShowMenu()
    {
        canvasGroup.alpha = 1;
        canvasGroup.interactable = true;
    }


    private void HideMenu()
    {
        canvasGroup.alpha = 0;
        canvasGroup.interactable = false;
    }

    private void Update()
    {
        HandleInput();
    }

    private void HandleInput()
    {
        if (Input.GetButtonDown("Show Inventory Menu"))
            if (isVisible)
                HideMenu();
            else
                ShowMenu();
    }

    private void Awake()
    {
        if (instance == null)
            instance = this;

        else
            throw new System.Exception("There is alreadya n instance of InventoryMenu and there can only be one.");

        canvasGroup = GetComponent<CanvasGroup>();
        HideMenu();
    }
}
