using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Linq;

public class SettingsManager : MonoBehaviour
{
    public ToggleGroup toggleGroup;
    public string SoundtrackName;
    void Start()
    {
        // İlk toggle seçimini kontrol et
        EnsureSingleSelection();

        // Toggle değişimlerini dinle
        foreach (Toggle toggle in toggleGroup.GetComponentsInChildren<Toggle>())
        {
            toggle.onValueChanged.AddListener(delegate {
                OnToggleValueChanged(toggle);
            });
        }
    }
    void EnsureSingleSelection()
    {
        Toggle selectedToggle = toggleGroup.ActiveToggles().FirstOrDefault();

        if (selectedToggle == null && toggleGroup.transform.childCount > 0)
        {
            // Eğer hiçbir toggle seçili değilse, ilk toggle'ı seç
            toggleGroup.transform.GetChild(0).GetComponent<Toggle>().isOn = true;
        }
    }

    void OnToggleValueChanged(Toggle changedToggle)
    {
        if (changedToggle.isOn)
        {
            // Sadece bir toggle'ın seçili olduğundan emin ol
            foreach (Toggle toggle in toggleGroup.GetComponentsInChildren<Toggle>())
            {
                if (toggle != changedToggle)
                {
                    toggle.isOn = false;
                }
            }

            // Seçili toggle'ın label'ındaki yazıyı al
            Text label = changedToggle.GetComponentInChildren<Text>();
            if (label != null)
            {
                SoundtrackName = label.text;
                Debug.Log("Selected Soundtrack: " + SoundtrackName);
            }
        }
    }

/*
    public void BackToGame()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.LoadPreviousScene();
        }
        else
        {
            Debug.LogError("GameManager instance is not found!");
        }
    }
    */
        

}