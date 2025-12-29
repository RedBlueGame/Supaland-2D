using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public GameObject Minecart;

    private void OnEnable()
    {
        FindObjectOfType<CameraComponent>().Target = Minecart;
    }

    private void OnDisable()
    {
        FindObjectOfType<CameraComponent>().Target = FindObjectOfType<Player>().gameObject;
    }

}
