using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class darkFireScript : MonoBehaviour
{
    public GameObject darkbullet5; // Mermi Prefab'ı
    public Transform firepoint;     // Merminin çıkış noktası
     public float fireInterval = 2f;  // Ateşleme aralığı (saniye cinsinden)

    void Start()
    {
        StartCoroutine(ShootCoroutine());
    }
    
    IEnumerator ShootCoroutine()
{
    while (true)
    {
        Shoot(); // Shoot fonksiyonunu çağır
        yield return new WaitForSeconds(fireInterval); // 2 saniye bekle
    }
}

    void Shoot()
    {
        Instantiate(darkbullet5, firepoint.position, firepoint.rotation);
    }
}
