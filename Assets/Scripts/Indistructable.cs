using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indistructable : MonoBehaviour
{

    void Update()
    {
        DontDestroyOnLoad(gameObject);
    }
}
