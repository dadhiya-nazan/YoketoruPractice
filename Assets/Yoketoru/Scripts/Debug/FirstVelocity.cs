using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstVelocity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = 2 * Vector3.right;   
    }
}
