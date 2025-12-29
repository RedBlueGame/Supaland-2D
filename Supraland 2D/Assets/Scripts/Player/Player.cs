using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject[] Skins;

    private void Start()
    {
        foreach (GameObject skin in Skins)
        {
            skin.SetActive(false);
        }

        Skins[0].SetActive(true);
    }

    public void EquipArmor()
    {
        foreach (GameObject skin in Skins)
        {
            skin.SetActive(false);
        }
        
        Skins[1].SetActive(true);
    }
}
