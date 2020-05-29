using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class losscollider : MonoBehaviour
{
    public int lossThreshhold = 5;
    private int losses = 0;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "destroyable")
        {
          if (lossThreshhold <= losses) {
            SceneManager.LoadScene("LossSplash");
          }
          losses += 1;
        }
    }
}
