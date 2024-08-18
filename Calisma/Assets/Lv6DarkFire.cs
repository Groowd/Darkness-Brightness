using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv6DarkFire : MonoBehaviour
{
    public GameObject darkbullet6; // Mermi Prefab'ı
    public Transform darkfirepoint6;     // Merminin çıkış noktası
     public float darkfireInterval6 = 2f;  // Ateşleme aralığı (saniye cinsinden)

    void Start()
    {
        StartCoroutine(ShootCoroutine());
    }
    
    IEnumerator ShootCoroutine()
{
    while (true)
    {
        Shoot(); // Shoot fonksiyonunu çağır
        yield return new WaitForSeconds(darkfireInterval6); // 2 saniye bekle
    }
}

    void Shoot()
    {
        Instantiate(darkbullet6, darkfirepoint6.position, darkfirepoint6.rotation);
    }
}
