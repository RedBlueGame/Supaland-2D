using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HoldableType : MonoBehaviour
{
    public void ShowCanvas()
    {
        HoldText.SetActive(true);
    }

    public void HideCanvas()
    {
        HoldText.SetActive(false);
    }



    public GameObject HoldText;



}
