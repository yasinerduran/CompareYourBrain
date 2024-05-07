using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Material defaultMaterial;
    public Material selectedMaterial;

    public void SetSelectedMaterial()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();

        // Eğer MeshRenderer bileşeni varsa
        if (meshRenderer != null)
        {
            // Materyali değiştir
            meshRenderer.material = selectedMaterial;
        }
        else
        {
            Debug.LogError("MeshRenderer bileşeni bulunamadı!");
        }
    }
    
    public void SetDefaultMaterial()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();

        // Eğer MeshRenderer bileşeni varsa
        if (meshRenderer != null)
        {
            // Materyali değiştir
            meshRenderer.material = defaultMaterial;
        }
        else
        {
            Debug.LogError("MeshRenderer bileşeni bulunamadı!");
        }
    }

    public UnityEngine.Color GetActiveMaterial()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        Material[] materyaller = meshRenderer.materials;
        return materyaller[0].color;
    }
}
