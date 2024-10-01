using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour
{
    public float speed = 5.0f;
<<<<<<< HEAD

=======
>>>>>>> 99ef4e91d26f52a5246b40d41ac1c6a98b7c8594
    public float height = 3f;

    void Update()
    {
        var y = Mathf.Sin(Time.time * speed) * height;

<<<<<<< HEAD
        y = Mathf.Abs(y);
=======
        //make y always positive - use absolute value
        y = Mathf.Abs(y); //+1, -1 (adjust)
>>>>>>> 99ef4e91d26f52a5246b40d41ac1c6a98b7c8594

        var x = transform.position.x;
        var z = transform.position.z;

        transform.position = new Vector3(x, y, z);
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 99ef4e91d26f52a5246b40d41ac1c6a98b7c8594
