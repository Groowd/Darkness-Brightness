using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Unity.VisualScripting;

public class DarkBoostTimeChecker : MonoBehaviour
{
    int boostTime=5;
    bool girdi=false;
    DarkPlayerScript DarkPlayerAccess;
    // Start is called before the first frame update
    void Start()
    {
        DarkPlayerAccess = FindObjectOfType<DarkPlayerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        //TextMeshProUGUI level6DarkBoostTimeText = GetComponent<TextMeshProUGUI>();
        //level6DarkBoostTimeText.text="Boost Time: "+DarkPlayerAccess.boostDuration.ToString();
        if(DarkPlayerAccess.DarkBoostOn==true && girdi==false){
            StartCoroutine(UpdateDarkBoostTime());
            girdi=true;
        } 
    }
    public IEnumerator UpdateDarkBoostTime()
    {   
        TextMeshProUGUI level6DarkBoostTimeText = GetComponent<TextMeshProUGUI>();
        level6DarkBoostTimeText.text="Boost Time: "+boostTime.ToString(); 
        yield return new WaitForSecondsRealtime(1);
        boostTime-=1;
        level6DarkBoostTimeText.text="Boost Time: "+boostTime.ToString(); 
        yield return new WaitForSecondsRealtime(1);
        boostTime-=1;
        level6DarkBoostTimeText.text="Boost Time: "+boostTime.ToString();
        yield return new WaitForSecondsRealtime(1); 
        boostTime-=1;
        level6DarkBoostTimeText.text="Boost Time: "+boostTime.ToString();
        yield return new WaitForSecondsRealtime(1); 
        boostTime-=1;
        level6DarkBoostTimeText.text="Boost Time: "+boostTime.ToString();
        yield return new WaitForSecondsRealtime(1);
        boostTime-=1;
        level6DarkBoostTimeText.text="Boost Time: "+boostTime.ToString();  
    }
}
