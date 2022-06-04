using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuitLoader : MonoBehaviour
{
    public Button quitButton;

    void Start()
    {
        Button btn = quitButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("halo");
        Application.Quit();
    }
}