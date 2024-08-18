using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BrightPortalControl : MonoBehaviour
{
    DarkPlayerScript DarkPlayerAccess2;
    DarkPortalControl DarkPortalAccess2;
    BrightPlayerScript BrightPlayerAccess2;
    public bool BrightPlayerOnPortal;
    public bool BrightPlayerOnPortal2;
    public bool BrightPlayerOnPortal3;
    public bool BrightPlayerOnPortal4;
    public bool BrightPlayerOnPortal5;
    public bool BrightPlayerOnPortal6;
    void Start() {
    DarkPlayerAccess2 = FindObjectOfType<DarkPlayerScript>();
    DarkPortalAccess2 = FindObjectOfType<DarkPortalControl>();
    BrightPlayerAccess2 = FindObjectOfType<BrightPlayerScript>();
    }
    void OnTriggerEnter2D(Collider2D other2) {
        if(other2.CompareTag("BrightPlayer")) {
            BrightPlayerOnPortal=true;
            BtoLevel2();
        }
        else if(other2.CompareTag("BrightPlayer2")) {
            BrightPlayerOnPortal2=true;
            BtoLevel3();
        }
        else if(other2.CompareTag("BrightPlayer3")) {
            BrightPlayerOnPortal3=true;
            BtoLevel4();
        }
        else if(other2.CompareTag("BrightPlayer4")) {
            BrightPlayerOnPortal4=true;
            BtoLevel5();
        }
        else if(other2.CompareTag("BrightPlayer5")) {
            BrightPlayerOnPortal5=true;
            BtoLevel6();
        }
        else if(other2.CompareTag("BrightPlayer6")) {
            BrightPlayerOnPortal6=true;
            BtoFinish();
        }
    }
    void OnTriggerExit2D(Collider2D other2) {
        if(other2.CompareTag("BrightPlayer")) {
            BrightPlayerOnPortal=false;
        }
        else if(other2.CompareTag("BrightPlayer2")) {
            BrightPlayerOnPortal2=false;
        }
        else if(other2.CompareTag("BrightPlayer3")) {
            BrightPlayerOnPortal3=false;
        }
        else if(other2.CompareTag("BrightPlayer4")) {
            BrightPlayerOnPortal4=false;
        }
        else if(other2.CompareTag("BrightPlayer5")) {
            BrightPlayerOnPortal5=false;
        }
        else if(other2.CompareTag("BrightPlayer6")) {
            BrightPlayerOnPortal6=false;
        }
    }
    public void BtoLevel2(){
       if(DarkPlayerAccess2.DarkPoints==4 && BrightPlayerOnPortal==true && BrightPlayerAccess2.BrightPoints==4 && DarkPortalAccess2.DarkPlayerOnPortal==true){
        SceneManager.LoadScene("LevelUpToTwo");
       }
    }  
    public void BtoLevel3(){
       if(DarkPlayerAccess2.DarkPoints2==5 && BrightPlayerOnPortal2==true && BrightPlayerAccess2.BrightPoints2==5 && DarkPortalAccess2.DarkPlayerOnPortal2==true){
        SceneManager.LoadScene("LevelUpToThree");
       }
    }
    public void BtoLevel4(){
       if(DarkPlayerAccess2.DarkPoints3==5 && BrightPlayerOnPortal3==true && BrightPlayerAccess2.BrightPoints3==5 && DarkPortalAccess2.DarkPlayerOnPortal3==true){
        SceneManager.LoadScene("LevelUpToFour");
       }
    }  
    public void BtoLevel5(){
       if(DarkPlayerAccess2.DarkPoints4==5 && BrightPlayerOnPortal4==true && BrightPlayerAccess2.BrightPoints4==5 && DarkPortalAccess2.DarkPlayerOnPortal4==true){
        SceneManager.LoadScene("LevelUpToFive");
       }
    }   
    public void BtoLevel6(){
       if(DarkPlayerAccess2.DarkPoints5==5 && BrightPlayerOnPortal5==true && BrightPlayerAccess2.BrightPoints5==5 && DarkPortalAccess2.DarkPlayerOnPortal5==true){
        SceneManager.LoadScene("LevelUpToSix");
       }
    }  
    public void BtoFinish(){
       if(DarkPlayerAccess2.DarkPoints6==5 && BrightPlayerOnPortal6==true && BrightPlayerAccess2.BrightPoints6==5 && DarkPortalAccess2.DarkPlayerOnPortal6==true){
        SceneManager.LoadScene("MainMenu");
       }
    } 
}

