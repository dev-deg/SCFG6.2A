using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoozyController : MonoBehaviour
{
    private Animator _animator;
    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    
    void Update()
    {
        bool isWalking = _animator.GetBool("isWalking");
        
        bool forwardPressed = Input.GetKey("w");
        if(!isWalking && forwardPressed)
        {
            _animator.SetBool("isWalking", true);
        }
        if(isWalking && !forwardPressed)
        {
            _animator.SetBool("isWalking", false);
        }
    }
}