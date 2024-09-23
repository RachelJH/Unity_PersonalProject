using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    void Start()
    {
        transform.position = new Vector3(5, 5, 5);
        transform.localScale = Vector3.one * 3.0f;
        
        Material material = Renderer.material;
        
        material.color = new Color(0f, 0f, 0f, 0.8f);
    }
    
    void Update()
    {
        transform.Rotate(10.0f * Time.deltaTime * 2, 10.0f * Time.deltaTime * 1.5f, 0.0f);
    }
}
