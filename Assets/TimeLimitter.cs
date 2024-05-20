using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeLimitter : MonoBehaviour
{
    public float countdownTime = 5.0f; // Sayaç süresi
    private float currentTime;
    public TextMeshProUGUI countdownText; // UI Text bileşeni

    void Start()
    {
        currentTime = countdownTime; // Sayaç başlangıç süresini ayarla
        UpdateCountdownText(); // UI'yi güncelle
    }

    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime; // Zamanı azalt
            UpdateCountdownText(); // UI'yi güncelle
            if (currentTime <= 0)
            {
                currentTime = 0;
                OnCountdownEnd(); // Sayaç bittiğinde çağrılacak fonksiyon
            }
        }
    }

    void UpdateCountdownText()
    {
        countdownText.text = currentTime.ToString("F2"); // UI Text'i güncelle
    }

    void OnCountdownEnd()
    {
        currentTime = 5.0f;
        Debug.Log("Sayaç bitti!");
        // Burada sayaç bittiğinde gerçekleştirilmek istenen işlemi ekleyebilirsiniz
    }

    public void AddTime(float time = 5f)
    {
        currentTime += time;
    }
}
