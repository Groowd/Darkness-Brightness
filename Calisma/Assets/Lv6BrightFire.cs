using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv6BrightFire : MonoBehaviour
{
    public GameObject brightbullet6; // Mermi Prefab'ı
    public Transform Brightfirepoint6;     // Merminin çıkış noktası
    public float BrightfireInterval6 = 1f;  // Ateşleme aralığı (saniye cinsinden)

    void Start()
    {
        StartCoroutine(ShootCoroutine());
    }
    IEnumerator ShootCoroutine()
{
    while (true)
    {
        Shoot(); // Shoot fonksiyonunu çağır
        yield return new WaitForSeconds(BrightfireInterval6); // 1 saniye bekle
    }
}

    void Shoot()
    {
        Instantiate(brightbullet6, Brightfirepoint6.position, Brightfirepoint6.rotation);
    }
}
