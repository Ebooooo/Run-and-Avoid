using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DmgPan : MonoBehaviour
{

    private PlayerController player;

    void Start()
    {
        player = GameObject.Find("Becon").GetComponent<PlayerController>();
    }


    void OnTriggerEnter2D(Collider2D dmgPan) 
    {
       if(dmgPan.CompareTag("Player")){
           player.Damage(1);
           StartCoroutine(player.Knockback(0.02f, 120, player.transform.position));
       } 
    }
}
