using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    public float genSpeed;
    public float subSpeed;
    public bool isSpinning = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isSpinning)
        {
            SpinWheel();
        }

        if (isSpinning)
        {
            transform.Rotate(0, genSpeed, 0);
            genSpeed -= subSpeed;
        }

        if (genSpeed <= 0)
        {
            genSpeed = 0;
            isSpinning = false;
        }
        
    }

    public void SpinWheel()
    {
        genSpeed = Random.Range(2.000f, 5.000f);
        subSpeed = Random.Range(0.003f, 0.005f);

        isSpinning = true;
        Debug.Log(genSpeed);
    }
}
