using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DarkPortalControl : MonoBehaviour
{
    DarkPlayerScript DarkPlayerAccess;
    BrightPortalControl BrightPortalAccess;
    BrightPlayerScript BrightPlayerAccess;
    public bool DarkPlayerOnPortal;
    public bool DarkPlayerOnPortal2;
    public bool DarkPlayerOnPortal3;
    public bool DarkPlayerOnPortal4;
    public bool DarkPlayerOnPortal5;
    public bool DarkPlayerOnPortal6;
    void Start() {
    DarkPlayerAccess = FindObjectOfType<DarkPlayerScript>();
    BrightPortalAccess = FindObjectOfType<BrightPortalControl>();
    BrightPlayerAccess = FindObjectOfType<BrightPlayerScript>();
    }
    
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("DarkPlayer")) {
            DarkPlayerOnPortal=true;
            DtoLevel2();
        }
        else if(other.CompareTag("DarkPlayer2")) {
            DarkPlayerOnPortal2=true;
            DtoLevel3();
        }
        else if(other.CompareTag("DarkPlayer3")) {
            DarkPlayerOnPortal3=true;
            DtoLevel4();
        }
        else if(other.CompareTag("DarkPlayer4")) {
            DarkPlayerOnPortal4=true;
            DtoLevel5();
        }
        else if(other.CompareTag("DarkPlayer5")) {
            DarkPlayerOnPortal5=true;
            DtoLevel6();
        }
        else if(other.CompareTag("DarkPlayer6")) {
            DarkPlayerOnPortal6=true;
            DtoFinish();
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag("DarkPlayer")) {
            DarkPlayerOnPortal=false;
        }
        else if(other.CompareTag("DarkPlayer2")) {
            DarkPlayerOnPortal2=false;
        }
        else if(other.CompareTag("DarkPlayer3")) {
            DarkPlayerOnPortal3=false;
        }
        else if(other.CompareTag("DarkPlayer4")) {
            DarkPlayerOnPortal4=false;
        }
        else if(other.CompareTag("DarkPlayer5")) {
            DarkPlayerOnPortal5=false;
        }
        else if(other.CompareTag("DarkPlayer6")) {
            DarkPlayerOnPortal6=false;
        }
    }
    public void DtoLevel2(){
       if(DarkPlayerAccess.DarkPoints==4 && BrightPortalAccess.BrightPlayerOnPortal==true && BrightPlayerAccess.BrightPoints==4 && DarkPlayerOnPortal==true){
        SceneManager.LoadScene("LevelUpToTwo");
       }
    } 

    public void DtoLevel3(){
       if(DarkPlayerAccess.DarkPoints2==5 && BrightPortalAccess.BrightPlayerOnPortal2==true && BrightPlayerAccess.BrightPoints2==5 && DarkPlayerOnPortal2==true){
        SceneManager.LoadScene("LevelUpToThree");
       }
    }
    public void DtoLevel4(){
       if(DarkPlayerAccess.DarkPoints3==5 && BrightPortalAccess.BrightPlayerOnPortal3==true && BrightPlayerAccess.BrightPoints3==5 && DarkPlayerOnPortal3==true){
        SceneManager.LoadScene("LevelUpToFour");
       }
    } 
    public void DtoLevel5(){
       if(DarkPlayerAccess.DarkPoints4==5 && BrightPortalAccess.BrightPlayerOnPortal4==true && BrightPlayerAccess.BrightPoints4==5 && DarkPlayerOnPortal4==true){
        SceneManager.LoadScene("LevelUpToFive");
       }
    } 
    public void DtoLevel6(){
       if(DarkPlayerAccess.DarkPoints5==5 && BrightPortalAccess.BrightPlayerOnPortal5==true && BrightPlayerAccess.BrightPoints5==5 && DarkPlayerOnPortal5==true){
        SceneManager.LoadScene("LevelUpToSix");
       }
    } 
    public void DtoFinish(){
       if(DarkPlayerAccess.DarkPoints6==5 && BrightPortalAccess.BrightPlayerOnPortal6==true && BrightPlayerAccess.BrightPoints6==5 && DarkPlayerOnPortal6==true){
        SceneManager.LoadScene("MainMenu");
       }
    } 
}

