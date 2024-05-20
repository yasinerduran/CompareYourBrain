using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRandom : MonoBehaviour
{
    
    public float rotationStrength = 1f;

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        // Rastgele bir yön vektörü oluşturma
        Vector3 randomDirection = Random.onUnitSphere;

        // Rastgele yön vektörüne belirli bir kuvvetle torque ekleme
        rb.AddTorque(randomDirection * rotationStrength, ForceMode.Impulse);
    }


    public void Rotate()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        // Rastgele bir yön vektörü oluşturma
        Vector3 randomDirection = Random.onUnitSphere;

        // Rastgele yön vektörüne belirli bir kuvvetle torque ekleme
        rb.AddTorque(randomDirection * rotationStrength, ForceMode.Impulse);
    }
    // Start is called before the first frame update
   
}
