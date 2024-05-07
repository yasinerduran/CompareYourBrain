using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    bool dönmeDevamEdiyor = false;

    public void RandomRotate()
    {
        if (!dönmeDevamEdiyor)
        {
            StartCoroutine(DondurKup());
        }
    }
    IEnumerator DondurKup()
    {
        dönmeDevamEdiyor = true;

        // Rastgele bir ekseni seç
        int rastgeleEksen = Random.Range(0, 3); // 0:x, 1:y, 2:z

        // Küpü 90 derece döndür
        Quaternion hedefRotasyon = Quaternion.Euler(transform.rotation.eulerAngles + GetRastgeleEksenRotasyon(rastgeleEksen));
        float süre = 0.5f; // Dönme süresi (saniye)

        float geçenZaman = 0f;

        while (geçenZaman < süre)
        {
            // Küpü yavaşça döndür
            transform.rotation = Quaternion.Slerp(transform.rotation, hedefRotasyon, geçenZaman / süre);
            geçenZaman += Time.deltaTime;
            yield return null;
        }

        // Dönme tamamlandığında işaretçiyi sıfırla
        transform.rotation = hedefRotasyon;
        dönmeDevamEdiyor = false;
    }

    Vector3 GetRastgeleEksenRotasyon(int rastgeleEksen)
    {
        switch (rastgeleEksen)
        {
            case 0:
                return Vector3.right * 90f; // x ekseni
            case 1:
                return Vector3.up * 90f; // y ekseni
            case 2:
                return Vector3.forward * 90f; // z ekseni
            default:
                return Vector3.zero;
        }
    }
    
    void Update()
    {
        
    }
}
