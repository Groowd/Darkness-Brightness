using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Lv4BrightScore : MonoBehaviour
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
        TextMeshProUGUI level4BrightPlayerScoreText = GetComponent<TextMeshProUGUI>();
        level4BrightPlayerScoreText.text="BP: "+BrightPlayerAccess.BrightPoints4.ToString(); 
    }
}
