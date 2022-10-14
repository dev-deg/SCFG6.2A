using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoozyController : MonoBehaviour
{
    private Animator _animator;
    private readonly int _isWalkingHash = Animator.StringToHash("isWalking");
    
    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    
    void Update()
    {
        bool isWalking = _animator.GetBool(_isWalkingHash);
        
        bool forwardPressed = Input.GetKey("w");
        if(!isWalking && forwardPressed)
        {
            _animator.SetBool(_isWalkingHash, true);
        }
        if(isWalking && !forwardPressed)
        {
            _animator.SetBool(_isWalkingHash, false);
        }
    }
}