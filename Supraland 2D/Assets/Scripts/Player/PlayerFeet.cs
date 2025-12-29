using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class PlayerFeet : MonoBehaviour
{
    public PlayerMovement Player;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Player.JumpCount = Player.MaxJumpCount;
    }
}
