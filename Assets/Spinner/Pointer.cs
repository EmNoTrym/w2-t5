using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    public string pointerAt;

    private Spinner spinner;
    [SerializeField]
    private int desireNum = 9;

    private void Start()
    {
        spinner = GameObject.Find("Wheel").GetComponent<Spinner>();
    }

    private void Update()
    {
        if (spinner.isSpinning)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                desireNum = 1;
            }else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                desireNum = 2;
            }else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                desireNum = 3;
            }else if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                desireNum = 4;
            }else if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                desireNum = 5;
            }else if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                desireNum = 6;
            }else if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                desireNum = 7;
            }else if (Input.GetKeyDown(KeyCode.Alpha8))
            {
                desireNum = 8;
            }else if (Input.GetKeyDown(KeyCode.Alpha9))
            {
                desireNum = 9;
            }
        }

        if (spinner.isSpinning && pointerAt != desireNum.ToString() && spinner.genSpeed < 0.4f)
        {
            spinner.genSpeed = 0.4f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        pointerAt = other.gameObject.name;
    }
}
