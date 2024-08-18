using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class BrightPlayerScript : MonoBehaviour
{
    public bool BrightBoostOn;
    public AudioSource audioSource;
    public AudioClip clip1,clip2;
    private bool isBoosted2 = false;
    public float boostMultiplier2 = 2.2f; // Zıplama kuvveti çarpanı
    public float boostDuration2 = 5f; // Boost süresi
    public CapsuleCollider2D capsuleBright;
    public LayerMask layerBright;
    Rigidbody2D rb;
    Vector3 velo;
    public float speedAmountb = 12f;
    public float jumpAmountb = 12f;
    public int BrightPoints;
    public int BrightPoints2;
    public int BrightPoints3;
    public int BrightPoints4;
    public int BrightPoints5;
    public int BrightPoints6;
    DarkPortalControl DarkPortalAccess2;
    BrightPortalControl BrightPortalAccess2;
    DarkPlayerScript DarkPlayerAccess2;
    // Start is called before the first frame update
    void Start()
    {
        audioSource.clip=clip1;
        rb = GetComponent<Rigidbody2D>();
        capsuleBright = GetComponent<CapsuleCollider2D>();
        audioSource = GetComponent<AudioSource>();
        layerBright = LayerMask.GetMask("Platform");
        BrightPoints=0;
        BrightPoints2=0;
        BrightPoints3=0;
        BrightPoints4=0;
        BrightPoints5=0;
        BrightPoints6=0;
        BrightBoostOn=false;
    }
    
    // Update is called once per frame
    void Update()
    {
        velo = new Vector3(Input.GetAxis("BrightHorizontal"),0f);

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += velo * speedAmountb * Time.deltaTime;
            transform.rotation=Quaternion.Euler(0f,180f,0f);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += velo * speedAmountb * Time.deltaTime;
            transform.rotation=Quaternion.Euler(0f,0f,0f);
        }


        if (Input.GetKeyDown(KeyCode.W) && isOnFloorBright())
        {
            if(isBoosted2){
                rb.AddForce(Vector3.up * jumpAmountb*boostMultiplier2,ForceMode2D.Impulse);
            }
            else{
                rb.AddForce(Vector3.up * jumpAmountb,ForceMode2D.Impulse);
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
        else if(collision.gameObject.tag=="Traps6"){
            StartCoroutine(LoadLevelSixMenu());
        }
        else if(collision.gameObject.tag=="DarkBox6"){
            StartCoroutine(LoadLevelSixMenu());
        }
    }
    private void OnCollisionExit2D (Collision2D collision){
        //
    }
    private void OnTriggerEnter2D(Collider2D Bcol) {
        if (Bcol.gameObject.tag.Equals("boost"))
        {
            BrightBoostOn=true;
            Bcol.gameObject.SetActive(false);
            StartCoroutine(BoostJump2());
        }
        if(Bcol.gameObject.tag.Equals("DarkTrap2")){
            StartCoroutine(LoadLevelTwoMenu());
        }
        else if(Bcol.gameObject.tag.Equals("DarkTrap3") || Bcol.gameObject.tag.Equals("ToxicWater")){
            StartCoroutine(LoadLevelThreeMenu());
        }
        else if(Bcol.gameObject.tag.Equals("DarkTrap4") || Bcol.gameObject.tag.Equals("ToxicWater4")){
            StartCoroutine(LoadLevelFourMenu());
        }
        else if(Bcol.gameObject.tag.Equals("BrightTeleporter")){
            transform.position = new Vector3(-37, 9, 0);
        }
        else if(Bcol.gameObject.tag.Equals("DarkTrap5") || Bcol.gameObject.tag.Equals("ToxicWater5") || Bcol.gameObject.tag.Equals("DarkBullet5")){
            StartCoroutine(LoadLevelFiveMenu());
        }
        else if(Bcol.gameObject.tag.Equals("DarkTrap6") || Bcol.gameObject.tag.Equals("ToxicWater6") || Bcol.gameObject.tag.Equals("DarkBullet6")){
            StartCoroutine(LoadLevelSixMenu());
        }
        

    }  
    private void OnTriggerExit2D(Collider2D Bcol) {
        //
    } 
    public bool isOnFloorBright(){
        RaycastHit2D hitBright= Physics2D.CapsuleCast(capsuleBright.bounds.center,capsuleBright.bounds.size,CapsuleDirection2D.Vertical,0f,Vector2.down, 0.1f, layerBright);
        return hitBright;
    }  
    IEnumerator BoostJump2()
    {   
        audioSource.clip=clip2;
        audioSource.Play();
        isBoosted2 = true;
        yield return new WaitForSeconds(boostDuration2);
        audioSource.clip=clip1;
        isBoosted2 = false;
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


