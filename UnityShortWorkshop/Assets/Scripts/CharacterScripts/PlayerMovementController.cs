using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{

    [SerializeField, Range(1, 10)] float _speedMovement;
    [SerializeField, Range(1, 10)] float _speedTurn;
    CharacterController _characterController;
    // Start is called before the first frame update
    void Start()
    {
        _speedMovement = 1;
        _speedTurn = 1;
        _characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal_AD_buttons = Input.GetAxis("Horizontal"); 
        float vertical_WS_buttons = Input.GetAxis("Vertical");

        Vector3 forwardMovement = transform.forward * vertical_WS_buttons * _speedMovement;
        float rotateSpeed = horizontal_AD_buttons * _speedTurn;

        _characterController.SimpleMove(forwardMovement);
        transform.Rotate(0, rotateSpeed, 0);
    }
}
