using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Movement2 : MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {
        var x = Input.GetAxisRaw("Horizontal");
        var z = Input.GetAxisRaw("Vertical");

        transform.position += new Vector3(x, 0, z).normalized * speed * Time.deltaTime;
    }
}
