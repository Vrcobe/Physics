using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTryout : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("No me he chocado con " + other.name);
    }
}
