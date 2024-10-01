using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement2 : MonoBehaviour
{
    public float speed = 5.0f;

    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        var x = Input.GetAxisRaw("Horizontal");
        var z = Input.GetAxisRaw("Vertical");

        transform.position += new Vector3(x, 0, z).normalized * speed * Time.deltaTime;


    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            print("Game Over");
            var sneceName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(sneceName);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            print("Get Good");
        }
    }
}
