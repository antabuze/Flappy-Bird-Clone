using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private MeshRenderer _meshRenderer;
    
    public float parallaxSpeed;
    
    void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _meshRenderer.material.mainTextureOffset += new Vector2(parallaxSpeed * Time.deltaTime, 0);
    }
}
