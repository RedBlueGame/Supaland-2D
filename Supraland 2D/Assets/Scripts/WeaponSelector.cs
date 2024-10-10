using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSelector : MonoBehaviour
{

    public GameObject Sword;
    public GameObject MucGiffin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Sword.SetActive(true);
            MucGiffin.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Sword.SetActive(false);
            MucGiffin.SetActive(true);
        }
    }
}
