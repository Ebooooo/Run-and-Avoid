using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DmgWall : MonoBehaviour
{

    private PlayerController player;

    public void Start()
    {
        player = GameObject.Find("Becon").GetComponent<PlayerController>();
    }


    public void OnTriggerEnter2D(Collider2D col)
    {
       if(col.CompareTag("Player")){
           player.Damage(3);
           Debug.Log("halo");
           StartCoroutine(player.Knockback(0.5f, 120, player.transform.position));
       } 
    }
}
