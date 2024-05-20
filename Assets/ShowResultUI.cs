using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowResultUI : MonoBehaviour
{
    private Result resultManager;

    private TextMeshProUGUI ui;
    // Start is called before the first frame update
    void Start()
    {
        resultManager = FindObjectOfType<Result>();
        ui = GetComponent<TextMeshProUGUI>();
    }
    

    // Update is called once per frame
    void Update()
    {
        ui.text = resultManager.value.ToString();
    }
}
