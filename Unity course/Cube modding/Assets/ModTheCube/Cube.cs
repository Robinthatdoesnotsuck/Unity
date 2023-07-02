using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public float i = 0.01f;
    
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
    }
    
    void Update()
    {

        Material material = Renderer.material;

        //transform.Translate(transform.position);
        transform.Rotate(10.0f * Time.deltaTime, 5.0f * i, 0.0f);
        i += 0.01f;
        material.color = new Color(0.5f + i, 0.5f + i, 0.3f + i, 0.4f + i);
        transform.localScale += Vector3.one * (float)i * Time.deltaTime;
        if (transform.localScale.z >= 12 && transform.localScale.y >= 12 && transform.localScale.z >= 12)
        {
            transform.localScale = Vector3.one;
        } 
        if (i >= 22)
        {
            i = 1;
        }
        if (material.color.r >=  1.0f && material.color.g >= 1.0f && material.color.b >= 0.8f && material.color.a >= 0.9f)
        {
            material.color = new Color(0.5f, 0.5f, 0.3f, 0.4f);

        }
    }
}
