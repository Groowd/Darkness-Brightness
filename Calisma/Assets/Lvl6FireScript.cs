using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl6FireScript : MonoBehaviour
{
     public GameObject bullet6; // Mermi Prefab'ı
    public Transform firepoint6;     // Merminin çıkış noktası
    public float fireInterval6 = 3f;  // Ateşleme aralığı (saniye cinsinden)

    void Start()
    {
        StartCoroutine(ShootCoroutine());
    }
    
    IEnumerator ShootCoroutine()
{
    while (true)
    {
        Shoot(); // Shoot fonksiyonunu çağır
        yield return new WaitForSeconds(fireInterval6); // 3 saniye bekle
    }
}

    void Shoot()
    {
        Instantiate(bullet6, firepoint6.position, firepoint6.rotation);
    }
}
