using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GetCard : MonoBehaviour
{
    private BagOfCards cards;
    private Image image;
    public Number number;
    private bool filled = false;
    
    // Start is called before the first frame update
    void Start()
    {
        cards = FindObjectOfType<BagOfCards>();
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!filled)
        {
            if (cards.bag.Count>0)
            {
                number = cards.GetRandomCard();
                image.sprite = number.image;
                filled = true;
            }
        }
    }
}
