using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class Lv6BrightScore : MonoBehaviour
{
    BrightPlayerScript BrightPlayerAccess;
    // Start is called before the first frame update
    void Start()
    {
        BrightPlayerAccess = FindObjectOfType<BrightPlayerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        TextMeshProUGUI level6BrightPlayerScoreText = GetComponent<TextMeshProUGUI>();
        level6BrightPlayerScoreText.text="BP: "+BrightPlayerAccess.BrightPoints6.ToString(); 
    }
}
