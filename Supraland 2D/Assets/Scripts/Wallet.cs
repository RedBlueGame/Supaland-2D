using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Wallet : MonoBehaviour
{

    public int Coins;

    public GameObject TextMP;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextMP.GetComponent<TextMeshProUGUI>().text = Coins.ToString();
    }
}
