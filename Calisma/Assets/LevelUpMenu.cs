using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
public class LevelUpMenu : MonoBehaviour
{
    void Start() {

    }
    public void QuitGame(){
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
    }
    public void LevelUpToTwo(){
        SceneManager.LoadScene("LevelTwoScene");
    }
    public void LevelUpToThree(){
        SceneManager.LoadScene("LevelThreeScene");
    }
    public void LevelUpToFour(){
        SceneManager.LoadScene("LevelFourScene");
    }
    public void LevelUpToFive(){
        SceneManager.LoadScene("LevelFiveScene");
    }
    public void LevelUpToSix(){
        SceneManager.LoadScene("LevelSixScene");
    }
}
