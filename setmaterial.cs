using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public GameObject obj;
    public Material newMaterial;

    private void Start()
    {
        SetMaterial(obj, newMaterial);
    }

    private void SetMaterial(GameObject obj, Material mat)
    {
        // If the GameObject has a renderer, set its material.
        Renderer renderer = obj.GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material = mat;
        }

        // Loop through each child and recursively apply the method.
        foreach (Transform child in obj.transform)
        {
            SetMaterial(child.gameObject, mat);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
