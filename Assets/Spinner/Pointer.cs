using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pointer : MonoBehaviour
{
    public string pointerAt;

    private Spinner spinner;
    [SerializeField]
    private int desireNum = 9;
    [SerializeField]
    private GameObject[] sectors;

    private void Start()
    {
        spinner = GameObject.Find("Wheel").GetComponent<Spinner>();
    }

    private void Update()
    {
        if (spinner.isSpinning)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1) && sectors[0].activeSelf)
            {
                desireNum = 1;
            }else if (Input.GetKeyDown(KeyCode.Alpha2) && sectors[1].activeSelf)
            {
                desireNum = 2;
            }else if (Input.GetKeyDown(KeyCode.Alpha3) && sectors[2].activeSelf)
            {
                desireNum = 3;
            }else if (Input.GetKeyDown(KeyCode.Alpha4) && sectors[3].activeSelf)
            {
                desireNum = 4;
            }else if (Input.GetKeyDown(KeyCode.Alpha5) && sectors[4].activeSelf)
            {
                desireNum = 5;
            }else if (Input.GetKeyDown(KeyCode.Alpha6) && sectors[5].activeSelf)
            {
                desireNum = 6;
            }else if (Input.GetKeyDown(KeyCode.Alpha7) && sectors[6].activeSelf)
            {
                desireNum = 7;
            }else if (Input.GetKeyDown(KeyCode.Alpha8) && sectors[7].activeSelf)
            {
                desireNum = 8;
            }else if (Input.GetKeyDown(KeyCode.Alpha9) && sectors[8].activeSelf)
            {
                desireNum = 9;
            }
        }

        if (spinner.isSpinning && pointerAt != desireNum.ToString() && spinner.genSpeed < 0.4f)
        {
            spinner.genSpeed = 0.4f;
        }

        if (spinner.isTurned & !spinner.isSpinning)
        {
            disableSector();
            Teleport();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        pointerAt = other.gameObject.name;
    }

    private void OnTriggerExit(Collider other)
    {
        pointerAt = "0";
    }

    private void Teleport()
    {
        Debug.Log("Teleporting to Level " + pointerAt);
        spinner.isTurned = false;
        SceneManager.LoadScene(desireNum);
    }

    private void disableSector()
    {
        foreach (var sector in sectors)
        {
            if (sector.name == pointerAt)
            {
                sector.gameObject.SetActive(false);
            }
        }
    }

}
