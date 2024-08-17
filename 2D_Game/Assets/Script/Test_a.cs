using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_a : MonoBehaviour
{
    [SerializeField] private int _playerHealth = 100;
    private float _playerSpeed = 4.6f;
    private bool _isGrounded = true;
    private string _playerName = "Clara";
    private Vector3 _playerPosition = new Vector3(-5f, 0f, 0f);
    Rigidbody2D _rb;


    private void Start() {
        gameObject.transform.position = _playerPosition;
        _rb = gameObject.GetComponent<Rigidbody2D>();
        _rb.gravityScale = 0;
    }
}
