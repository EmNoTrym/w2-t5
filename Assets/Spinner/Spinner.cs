using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class Spinner : MonoBehaviour
{
    public float genSpeed;
    public float subSpeed;
    public bool isSpinning = false;
    public bool isTurned = false;
    public AudioSource source;
    public AudioClip clip;

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isSpinning)
        {
            SpinWheel();
            isTurned = true;
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
        genSpeed = Random.Range(4.000f, 6.000f);
        subSpeed = Random.Range(0.003f, 0.005f);
        source.PlayOneShot(clip);

        isSpinning = true;
    }

}
