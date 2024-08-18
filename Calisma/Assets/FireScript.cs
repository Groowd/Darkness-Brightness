using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour
{
    public GameObject bullet; // Mermi Prefab'ı
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
        Instantiate(bullet, firepoint.position, firepoint.rotation);
    }
}
