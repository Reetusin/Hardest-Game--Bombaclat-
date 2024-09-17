using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            print("Get Good");
        }
    }
}
