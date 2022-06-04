using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreUI : MonoBehaviour
{
    public Text scoreText;
    public float scoreAmount;
    public float pointPerSecond;
    public GameObject end;
    public GameObject oneHP;
    public GameObject twoHP;
    public GameObject threeHP;
    private PlayerController playerstate;
    private void Start()
    {
     scoreAmount = 0f;   
     pointPerSecond = 1f;
    }

    private void Update()
    {
       scoreText.text = "Actual Score " + (int)scoreAmount;
       scoreAmount += pointPerSecond * Time.deltaTime;
       showHP();
       ending();
    }

    public void showHP()
    {
        playerstate = GameObject.Find("Becon").GetComponent<PlayerController>();
        if(playerstate.CurHp <= 2)
        {
            oneHP.SetActive(true);
            twoHP.SetActive(true);
            threeHP.SetActive(false);
        }

        if(playerstate.CurHp <= 1)
        {
            oneHP.SetActive(true);
            twoHP.SetActive(false);
        }

        if(playerstate.CurHp <= 0)
        {
            oneHP.SetActive(false);
        }
    }
    public void ending()
    {
        playerstate = GameObject.Find("Becon").GetComponent<PlayerController>();
        if(playerstate.CurHp <= 0)
        end.SetActive(true);
    }
}
