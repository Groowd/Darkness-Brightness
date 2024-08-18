using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class BrightBoostTimeChecker : MonoBehaviour
{
    int BrightBoostTime=5;
    BrightPlayerScript BrightPlayerAccess;
    bool girdimi=false;
    // Start is called before the first frame update
    void Start()
    {
        BrightPlayerAccess = FindObjectOfType<BrightPlayerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(BrightPlayerAccess.BrightBoostOn==true && girdimi==false){
            StartCoroutine(UpdateDarkBoostTime());
            girdimi=true;
        } 
    }
     public IEnumerator UpdateDarkBoostTime()
    {   
        TextMeshProUGUI level6BrightBoostTimeText = GetComponent<TextMeshProUGUI>();
        level6BrightBoostTimeText.text="Boost Time: "+BrightBoostTime.ToString(); 
        yield return new WaitForSecondsRealtime(1);
        BrightBoostTime-=1;
        level6BrightBoostTimeText.text="Boost Time: "+BrightBoostTime.ToString(); 
        yield return new WaitForSecondsRealtime(1);
        BrightBoostTime-=1;
        level6BrightBoostTimeText.text="Boost Time: "+BrightBoostTime.ToString();
        yield return new WaitForSecondsRealtime(1); 
        BrightBoostTime-=1;
        level6BrightBoostTimeText.text="Boost Time: "+BrightBoostTime.ToString();
        yield return new WaitForSecondsRealtime(1); 
        BrightBoostTime-=1;
        level6BrightBoostTimeText.text="Boost Time: "+BrightBoostTime.ToString();
        yield return new WaitForSecondsRealtime(1);
        BrightBoostTime-=1;
        level6BrightBoostTimeText.text="Boost Time: "+BrightBoostTime.ToString();  
    }
}
