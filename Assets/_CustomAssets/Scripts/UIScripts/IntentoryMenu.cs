using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntentoryMenu : MonoBehaviour
{
    [SerializeField] GameObject inventoryMenu;
   


    
    public void Inventory()
    {
        inventoryMenu.SetActive(true);
        Time.timeScale = 1f;
    }

    public void Resume()
    {
        inventoryMenu.SetActive(false);
        Time.timeScale = 1f;
    }
}
