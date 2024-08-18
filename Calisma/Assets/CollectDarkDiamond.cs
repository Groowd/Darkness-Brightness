using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectDarkDiamond : MonoBehaviour
{   
    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.tag.Equals("DarkPlayer")){
            DarkPlayerScript DarkPlayer= collision.gameObject.GetComponent<DarkPlayerScript>();
            DarkPlayer.DarkPoints+=1;
            gameObject.SetActive(false);
        }
        else if(collision.gameObject.tag.Equals("DarkPlayer2")){
            DarkPlayerScript DarkPlayer= collision.gameObject.GetComponent<DarkPlayerScript>();
            DarkPlayer.DarkPoints2+=1;
            gameObject.SetActive(false);
        }
        else if(collision.gameObject.tag.Equals("DarkPlayer3")){
            DarkPlayerScript DarkPlayer= collision.gameObject.GetComponent<DarkPlayerScript>();
            DarkPlayer.DarkPoints3+=1;
            gameObject.SetActive(false);
        }
        else if(collision.gameObject.tag.Equals("DarkPlayer4")){
            DarkPlayerScript DarkPlayer= collision.gameObject.GetComponent<DarkPlayerScript>();
            DarkPlayer.DarkPoints4+=1;
            gameObject.SetActive(false);
        }
        else if(collision.gameObject.tag.Equals("DarkPlayer5")){
            DarkPlayerScript DarkPlayer= collision.gameObject.GetComponent<DarkPlayerScript>();
            DarkPlayer.DarkPoints5+=1;
            gameObject.SetActive(false);
        }
        else if(collision.gameObject.tag.Equals("DarkPlayer6")){
            DarkPlayerScript DarkPlayer= collision.gameObject.GetComponent<DarkPlayerScript>();
            DarkPlayer.DarkPoints6+=1;
            gameObject.SetActive(false);
        }
    }  
}

