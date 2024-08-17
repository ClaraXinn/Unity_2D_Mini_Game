using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rb;
    private float _playerSpeed = 8f;
    private float _inputHorizontal;

    [SerializeField] private ObjectBehaviour objectBehaviour;

    private void Start() {
        _rb = GetComponent<Rigidbody2D>();
        objectBehaviour.SpawnObject();
       
    }

    private void Update() {

        _inputHorizontal = Input.GetAxisRaw("Horizontal");

        _rb.AddForce(new Vector2(_inputHorizontal * _playerSpeed, 0f ));
        
        
    }




}
