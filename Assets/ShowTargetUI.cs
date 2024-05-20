using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ShowTargetUI : MonoBehaviour
{
    private TargetManager manager;
    private TextMeshProUGUI ui;
    // Start is called before the first frame update
    void Start()
    {
        manager = FindObjectOfType<TargetManager>();
        ui = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        ui.text = manager.targetValue.ToString();
    }
}
