using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_c : MonoBehaviour
{
    private int _playerHealth = 100;
    private int _playerShield = 100;

    public int PlayerHealth {
        get {
            return _playerHealth;
        }

        set {
            _playerHealth = value;
        }
    }

    public int PlayerShield {
        get {
            return _playerShield;
        }

        set {
            _playerShield = value;
        }
    }

    private void Start() {
        //int res = DamageTaken(180);
        //Debug.Log(res);

        Debug.Log("You took " + DamageTaken(180) + " in damage!");
    }

    int DamageTaken(int damage) {

        int damageTaken = 0 ;

        if ( damage < PlayerShield ) {
            Debug.Log("Shield not destroyed");
            
        }else if (damage == PlayerShield) {
            Debug.Log("Shield destroyed");

        }else {
            Debug.Log("Shield destroyed and damage taken!");
            damageTaken = damage - PlayerHealth;
        }

        return damageTaken;
    }

}
