using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameISEnded = false;
    public float revtime = 2f;
    public GameObject completelevelUI;

    public void completelevel()
    {
        completelevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (GameISEnded == false)
       {
            GameISEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", revtime);
          //  if (Input.GetKey("y"))
          //  {
          //      Invoke("Restart", revtime);
          //  }
           // if (Input.GetKey("n"))
           // {
           //     Debug.Log("ByeBye");
           // }
            
       }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
