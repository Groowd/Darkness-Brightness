using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;



public class DarkPlayerScript : MonoBehaviour
{
    public bool DarkBoostOn;
    public AudioSource audioSource;
    public AudioClip clip1,clip2;
    private bool isBoosted = false;
    public float boostMultiplier = 2.2f; // Zıplama kuvveti çarpanı
    public float boostDuration = 5f; // Boost süresi
    public CapsuleCollider2D capsule;
    public LayerMask layer;
    Rigidbody2D rgb;
    Vector3 velocity;
    public float speedAmount = 12f;
    public float jumpAmount = 12f;
    public int DarkPoints;
    public int DarkPoints2;
    public int DarkPoints3;
    public int DarkPoints4;
    public int DarkPoints5;
    public int DarkPoints6;

    // Start is called before the first frame update
    DarkPortalControl DarkPortalAccess;
    BrightPortalControl BrightPortalAccess;
    BrightPlayerScript BrightPlayerAccess;
    void Start()
    {
       audioSource.clip=clip1;
       rgb = GetComponent<Rigidbody2D>();
       capsule = GetComponent<CapsuleCollider2D>();
       audioSource = GetComponent<AudioSource>();
       layer = LayerMask.GetMask("Platform");
       DarkPoints=0;
       DarkPoints2=0;
       DarkPoints3=0;
       DarkPoints4=0;
       DarkPoints5=0;
       DarkPoints6=0;
       DarkBoostOn=false;
    }

    // Update is called once per frame
    void Update()
    {
        velocity = new Vector3(Input.GetAxis("DarkHorizontal"),0f);
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            
            transform.position += velocity * speedAmount * Time.deltaTime;
            transform.rotation=Quaternion.Euler(0f,180f,0f);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += velocity * speedAmount * Time.deltaTime;
            transform.rotation=Quaternion.Euler(0f,0f,0f);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && isOnFloor())
        {
            if(isBoosted){
                rgb.AddForce(Vector3.up * jumpAmount*boostMultiplier,ForceMode2D.Impulse);
            }
            else{
                rgb.AddForce(Vector3.up * jumpAmount,ForceMode2D.Impulse);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag=="Traps"){
            StartCoroutine(LoadMainMenu());
        }
        else if(collision.gameObject.tag=="Traps2"){
            StartCoroutine(LoadLevelTwoMenu());
        }
        else if(collision.gameObject.tag=="Traps3"){
            StartCoroutine(LoadLevelThreeMenu());
        }
        else if(collision.gameObject.tag=="Traps4"){
            StartCoroutine(LoadLevelFourMenu());
        }
        else if(collision.gameObject.tag=="Traps5"){
            StartCoroutine(LoadLevelFiveMenu());
        }
        else if(collision.gameObject.tag=="BrightBox"){
            StartCoroutine(LoadLevelFiveMenu());
        }
        else if(collision.gameObject.tag=="Traps6"){
            StartCoroutine(LoadLevelSixMenu());
        }
        else if(collision.gameObject.tag=="BrightBox6"){
            StartCoroutine(LoadLevelSixMenu());
        }
        
    }
    
    private void OnCollisionExit2D (Collision2D collision){
        //
    }

    private void OnTriggerEnter2D(Collider2D Dcol) {
        if (Dcol.gameObject.tag.Equals("boost"))
        {
            DarkBoostOn=true;
            Dcol.gameObject.SetActive(false);
            StartCoroutine(BoostJump());
        }
        if(Dcol.gameObject.tag.Equals("BrightTrap2")){
            StartCoroutine(LoadLevelTwoMenu());
        }
        else if(Dcol.gameObject.tag.Equals("BrightTrap3") || Dcol.gameObject.tag.Equals("ToxicWater")){
            StartCoroutine(LoadLevelThreeMenu());
        }
        else if(Dcol.gameObject.tag.Equals("BrightTrap4") || Dcol.gameObject.tag.Equals("ToxicWater4")){
            StartCoroutine(LoadLevelFourMenu());
        }
        else if(Dcol.gameObject.tag.Equals("DarkTeleporter")){
            transform.position = new Vector3(37, 9, 0);
        }
        else if(Dcol.gameObject.tag.Equals("BrightTrap5") || Dcol.gameObject.tag.Equals("ToxicWater5") || Dcol.gameObject.tag.Equals("BrightBullet5")){
            StartCoroutine(LoadLevelFiveMenu());
        }
        else if(Dcol.gameObject.tag.Equals("BrightTrap6") || Dcol.gameObject.tag.Equals("ToxicWater6") || Dcol.gameObject.tag.Equals("BrightBullet6")){
            StartCoroutine(LoadLevelSixMenu());
        }
        
        
        
    }  
    private void OnTriggerExit2D(Collider2D Dcol) {
        //
    }

    public bool isOnFloor(){
        RaycastHit2D hit= Physics2D.CapsuleCast(capsule.bounds.center,capsule.bounds.size,CapsuleDirection2D.Vertical,0f,Vector2.down, 0.1f, layer);
        return hit;
    }    
    IEnumerator BoostJump()
    {
        audioSource.clip=clip2;
        audioSource.Play();
        isBoosted = true;
        yield return new WaitForSeconds(boostDuration);
        audioSource.clip=clip1;
        isBoosted = false;
    }
    IEnumerator LoadMainMenu()
    {
        audioSource.Play();
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(2);
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
    IEnumerator LoadLevelTwoMenu()
    {
        audioSource.Play();
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(2);
        Time.timeScale = 1f;
        SceneManager.LoadScene("LevelUpToTwo");
    }
    IEnumerator LoadLevelThreeMenu()
    {
        audioSource.Play();
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(2);
        Time.timeScale = 1f;
        SceneManager.LoadScene("LevelUpToThree");
    }
    IEnumerator LoadLevelFourMenu()
    {
        audioSource.Play();
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(2);
        Time.timeScale = 1f;
        SceneManager.LoadScene("LevelUpToFour");
    }
    IEnumerator LoadLevelFiveMenu()
    {
        audioSource.Play();
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(2);
        Time.timeScale = 1f;
        SceneManager.LoadScene("LevelUpToFive");
    }
    IEnumerator LoadLevelSixMenu()
    {
        audioSource.Play();
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(2);
        Time.timeScale = 1f;
        SceneManager.LoadScene("LevelUpToSix");
    }

    
}

