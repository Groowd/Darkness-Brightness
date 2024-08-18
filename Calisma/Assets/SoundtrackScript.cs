using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class SoundtrackScript : MonoBehaviour
{
    public string SoundTrackNameToPlay; // Tikli olan Toggle'ın label yazısını saklamak için
    public bool noSoundTrack;
    public AudioSource audioSource;
    public AudioClip st1,st2,st3,st4,st5,st6;
    public bool playControl;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        playControl=true;
        audioSource.clip=st3;
        if(noSoundTrack==true){
            audioSource.Stop(); 
        }
        else{
            if(SoundTrackNameToPlay =="D957No4Serenade"){
                audioSource.clip=st1;
            }
            else if(SoundTrackNameToPlay =="enterTheEast"){
                audioSource.clip=st2;
            }
            else if(SoundTrackNameToPlay =="gameOfThrones"){
                audioSource.clip=st3;
            }
            else if(SoundTrackNameToPlay =="NocturneMinorNo20"){
                audioSource.clip=st4;
            }
            else if(SoundTrackNameToPlay =="superMario"){
                audioSource.clip=st5;
            }
            else if(SoundTrackNameToPlay =="theBarberOfSeville"){
                audioSource.clip=st6;
            }   
            audioSource.Play();
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        if(noSoundTrack==true){
            audioSource.Stop(); 
        }
        else{
            if(playControl==true){
                audioSource.Stop(); 
                if(SoundTrackNameToPlay =="D957No4Serenade"){
                audioSource.clip=st1;
                }
                else if(SoundTrackNameToPlay =="enterTheEast"){
                    audioSource.clip=st2;
                }
                else if(SoundTrackNameToPlay =="gameOfThrones"){
                    audioSource.clip=st3;
                }
                else if(SoundTrackNameToPlay =="NocturneMinorNo20"){
                    audioSource.clip=st4;
                }
                else if(SoundTrackNameToPlay =="superMario"){
                    audioSource.clip=st5;
                }
                else if(SoundTrackNameToPlay =="theBarberOfSeville"){
                    audioSource.clip=st6;
                }   
            audioSource.Play();
            playControl=false;
            }
        }
        
    }
}
