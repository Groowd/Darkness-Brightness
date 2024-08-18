using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectBrightDiamond : MonoBehaviour
{  
    private void OnTriggerEnter2D(Collider2D collision2) {
        if(collision2.gameObject.tag.Equals("BrightPlayer")){
            BrightPlayerScript BrightPlayer = collision2.gameObject.GetComponent<BrightPlayerScript>();
            BrightPlayer.BrightPoints+=1;
            gameObject.SetActive(false);
        }
        else if(collision2.gameObject.tag.Equals("BrightPlayer2")){
            BrightPlayerScript BrightPlayer = collision2.gameObject.GetComponent<BrightPlayerScript>();
            BrightPlayer.BrightPoints2+=1;
            gameObject.SetActive(false);
        }
        else if(collision2.gameObject.tag.Equals("BrightPlayer3")){
            BrightPlayerScript BrightPlayer = collision2.gameObject.GetComponent<BrightPlayerScript>();
            BrightPlayer.BrightPoints3+=1;
            gameObject.SetActive(false);
        }
        else if(collision2.gameObject.tag.Equals("BrightPlayer4")){
            BrightPlayerScript BrightPlayer = collision2.gameObject.GetComponent<BrightPlayerScript>();
            BrightPlayer.BrightPoints4+=1;
            gameObject.SetActive(false);
        }
        else if(collision2.gameObject.tag.Equals("BrightPlayer5")){
            BrightPlayerScript BrightPlayer = collision2.gameObject.GetComponent<BrightPlayerScript>();
            BrightPlayer.BrightPoints5+=1;
            gameObject.SetActive(false);
        }
        else if(collision2.gameObject.tag.Equals("BrightPlayer6")){
            BrightPlayerScript BrightPlayer = collision2.gameObject.GetComponent<BrightPlayerScript>();
            BrightPlayer.BrightPoints6+=1;
            gameObject.SetActive(false);
        }
    } 
}
