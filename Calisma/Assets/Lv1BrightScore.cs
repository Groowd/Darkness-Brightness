using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Lv1BrightScore : MonoBehaviour
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
        TextMeshProUGUI level1BrightPlayerScoreText = GetComponent<TextMeshProUGUI>();
        level1BrightPlayerScoreText.text="BP: "+BrightPlayerAccess.BrightPoints.ToString(); 
    }
}
