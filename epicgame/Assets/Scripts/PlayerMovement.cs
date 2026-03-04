using System.Runtime.CompilerServices;
using UnityEngine;

public class PLayerMovement : MonoBehaviour
{
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.AddForce(0, 200, 500);
    }

    // Update is called once per frame, 
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}
