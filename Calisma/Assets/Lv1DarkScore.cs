using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Lv1DarkScore : MonoBehaviour
{
    DarkPlayerScript DarkPlayerAccess;
    // Start is called before the first frame update
    void Start()
    {
        DarkPlayerAccess = FindObjectOfType<DarkPlayerScript>();
    }
    
    // Update is called once per frame
    void Update()
    {
        TextMeshProUGUI level1DarkPlayerScoreText = GetComponent<TextMeshProUGUI>();
        level1DarkPlayerScoreText.text="DP: "+DarkPlayerAccess.DarkPoints.ToString(); 
    }
}