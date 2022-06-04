using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStarting : MonoBehaviour
{
 void update()
 {
     if(Input.GetKeyDown(KeyCode.W))
     {
         SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);
         SceneManager.LoadScene("SampleScene");
     }
 }
}
