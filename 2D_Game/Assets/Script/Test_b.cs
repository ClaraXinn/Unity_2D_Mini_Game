using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_b : MonoBehaviour
{
    private int _playerHealth = 100;

    public int PlayerHealth {
        get {
            return _playerHealth;
        }

        set {
            _playerHealth = value;
        }
    }

    public string DisplayHealthPercentage {

        get {
            string health = _playerHealth.ToString() + "%";
            return health; 
        }
    }

    private void Start() {
        TakeDamage(45);
        Debug.Log(_playerHealth);
    }

    void TakeDamage(int damage) {
        PlayerHealth -= damage;
    }

    int ShowDamage() {
        PlayerHealth -= 10;
        return PlayerHealth;
    }

    

   
    

}
