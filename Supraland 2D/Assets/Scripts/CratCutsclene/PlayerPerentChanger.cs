using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPerentChanger : MonoBehaviour
{
    private void OnEnable()
    {
        Player player = FindObjectOfType<Player>();
        MineCart mineCart = FindObjectOfType<MineCart>();
        player.transform.SetParent (mineCart.transform , true);
        player.transform.localPosition = Vector3.zero + Vector3.up;
        player.GetComponent<Rigidbody2D>().simulated = false;
    }

    private void OnDisable()
    {
        Player player = FindObjectOfType<Player>();
        player.transform.SetParent(null , true);
        player.GetComponent<Rigidbody2D>().simulated = true;
    }
}
