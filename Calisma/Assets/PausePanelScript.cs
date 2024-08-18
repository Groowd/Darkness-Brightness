using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PausePanelScript : MonoBehaviour
{
    SoundtrackScript SoundTrackAccess;
     public GameObject PausePanel;
    public ToggleGroup toggleGroup; // ToggleGroup bileşeni
    public string SoundTrackName; // Tikli olan Toggle'ın label yazısını saklamak için
     public Toggle ToggleNoSoundtrack;
     public Slider SliderVolume; // Volume Slider referansı

    // Start is called before the first frame update
    void Start()
    {
        SoundTrackAccess = FindObjectOfType<SoundtrackScript>();
        SoundTrackAccess.playControl=true;
        GetSelectedToggle();
        CheckToggleNoSoundtrack();

        // Slider'ın onValueChanged olayına listener ekle
        if (SliderVolume != null)
        {
            SliderVolume.onValueChanged.AddListener(delegate { AdjustVolume(SliderVolume.value); });
        }

    }

    // Update is called once per frame
    void Update()
    {
        CheckToggleNoSoundtrack();
        GetSelectedToggle();
    }

    public void Pause()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0;
        SoundTrackAccess.playControl=true;
    }

    public void Continue()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1;
        SoundTrackAccess.playControl=true;
    }


    public void GetSelectedToggle()
    {
        // Tikli olan Toggle'ı bul
        Toggle selectedToggle = null;
        foreach (var toggle in toggleGroup.ActiveToggles())
        {
            selectedToggle = toggle;
            break;
        }

        // Eğer bir toggle seçiliyse, onun label text'ini al
        if (selectedToggle != null)
        {
            Text labelText = selectedToggle.GetComponentInChildren<Text>();
            if (labelText != null)
            {
                SoundTrackName = labelText.text;
                SoundTrackAccess.SoundTrackNameToPlay=SoundTrackName; 
            }
        }
        else
        {
            Debug.Log("No toggle is selected");
        }
    }
    public void CheckToggleNoSoundtrack()
    {
        if (ToggleNoSoundtrack != null && ToggleNoSoundtrack.isOn) //ToggleNoSoundtrack tikli ise buraya girer
        {
            SoundTrackAccess.noSoundTrack=true;
        }
        else //ToggleNoSoundtrack tiksiz ise buraya girer
        {
            SoundTrackAccess.noSoundTrack=false;
        }
    }
     // Volume ayarlama fonksiyonu
    public void AdjustVolume(float volume)
    {
        if (SoundTrackAccess != null)
        {
            // Volume değerini doğrudan AudioSource'a uygula
            SoundTrackAccess.GetComponent<AudioSource>().volume = volume;
            Debug.Log("Volume adjusted to: " + volume);
        }
        else
        {
            Debug.LogError("SoundtrackScript instance not found when trying to adjust volume!");
        }
    }
    
}
