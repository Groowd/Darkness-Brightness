using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Lv6DarkScore : MonoBehaviour
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
        TextMeshProUGUI level6DarkPlayerScoreText = GetComponent<TextMeshProUGUI>();
        level6DarkPlayerScoreText.text="DP: "+DarkPlayerAccess.DarkPoints6.ToString(); 
    }
}
