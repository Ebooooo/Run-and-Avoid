using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public PlayerController player;
    void Start()
    {
        player = GameObject.Find("Becon").GetComponent<PlayerController>();
    }
    void OnTriggerEnter2D(Collider2D col) 
    {
        if(col.CompareTag("Player"))
        {
        player.isGrounded = true;
        }    
    }
}
