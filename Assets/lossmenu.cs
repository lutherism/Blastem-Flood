using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lossmenu : MonoBehaviour
{
    public void RetryGame() {
      Debug.Log("retry");
      SceneManager.LoadScene("Gameplay");
    }

    public void QuitGame() {
      Application.Quit();
    }
}
