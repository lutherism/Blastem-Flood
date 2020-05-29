using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void PlayGame() {
      SceneManager.LoadScene("Gameplay");
    }

    public void QuitGame() {
      Application.Quit();
    }
}
