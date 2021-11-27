using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{
    [SerializeField] Animator _animator; 
    [SerializeField]CharacterController _characterController;

    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
        _animator = GetComponentInChildren<Animator>();
    }
    void Update()
    {
        _animator.SetFloat("Speed", _characterController.velocity.magnitude);
    }
}
