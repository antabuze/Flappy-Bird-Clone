using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Vector2 jumpHeight;
    public AudioSource jumpSound;
    
    private Rigidbody2D _rigidbody2D;
    

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!Input.GetMouseButtonDown(1)) return;
        
        JumpAction();
        
        if (jumpSound)
        {
            jumpSound.Play();
        }
    }

    private void JumpAction()
    {
        _rigidbody2D.velocity = Vector2.up * jumpHeight;
    }
}
