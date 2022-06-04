using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartCountdown : MonoBehaviour
{
    public Text countdowns;
    public int timerText;

    void Start()
    {
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        while(timerText > 0)
        {
            countdowns.text = timerText.ToString();

            yield return new WaitForSeconds(1f);

            timerText--;
        }

        countdowns.text = "Go!";

        yield return new WaitForSeconds(1f);

        countdowns.gameObject.SetActive(false);
    }
}