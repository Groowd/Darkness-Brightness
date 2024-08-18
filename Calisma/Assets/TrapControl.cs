using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrapControl : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("DarkPlayer") || other.CompareTag("BrightPlayer"))
        {
            SceneManager.LoadScene("MainMenu");
        }
        else if (other.CompareTag("DarkPlayer2") || other.CompareTag("BrightPlayer2"))
        {
            SceneManager.LoadScene("LevelUpToTwo");
        }
        else if (other.CompareTag("DarkPlayer3") || other.CompareTag("BrightPlayer3"))
        {
            SceneManager.LoadScene("LevelUpToThree");
        }
        else if (other.CompareTag("DarkPlayer4") || other.CompareTag("BrightPlayer4"))
        {
            SceneManager.LoadScene("LevelUpToFour");
        }
    }
}
