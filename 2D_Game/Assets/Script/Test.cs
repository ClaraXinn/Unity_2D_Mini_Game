using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    Rigidbody2D _rb;
    float walkSpeed = 5.5f;
    float inputHorizontal;
    // Start is called before the first frame update
    void Start()
    {
        
        _rb = gameObject.GetComponent<Rigidbody2D>();
        walkSpeed = 5.5f;
    }

    private void Update() {
        inputHorizontal = Input.GetAxisRaw("Horizontal");

        if (inputHorizontal != 0) {
            _rb.AddForce(new Vector2(inputHorizontal * walkSpeed, 0f));

        }

    }


}
