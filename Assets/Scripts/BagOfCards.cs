using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BagOfCards : MonoBehaviour
{
    public Number[] numbers;
    public List<Number> bag = new List<Number>();
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                bag.Add(numbers[i]);
            }
        }
    }

    public Number GetRandomCard()
    {
        var picked = Random.Range(0, bag.Count-1);
        var dummy = bag[picked];
        bag.Remove(dummy);
        return dummy;
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
