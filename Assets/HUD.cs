using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HUD : MonoBehaviour
{
    private int killCount = 0;
    public int killThreshold = 2000;
    public Text Score_UIText;

    public void onKill() {
      killCount += 1;
      if (killCount >= killThreshold) {
        SceneManager.LoadScene("WinSplash");
      }
      Score_UIText.text = $"{killCount}/{killThreshold}";
    }
}
