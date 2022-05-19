using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    private Spinner spin;

    private void Start()
    {
        spin = GameObject.Find("Wheel").GetComponent<Spinner>();
    }

    private void OnTriggerEnter(Collider other)
    {
        /*
        if (spin.isSpinning)
            Debug.Log(other.gameObject.name);
        */
    }
}
