using UnityEngine;
using System.Collections.Generic;
public class ChangeCamera : MonoBehaviour
{
    [SerializeField] GameObject FPCamera;
    [SerializeField] GameObject TPCamera;
    bool isChangeCamera = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (!isChangeCamera)
            {
                FPCamera.SetActive(true);
                TPCamera.SetActive(false);
                isChangeCamera = true;
            }
            else if(isChangeCamera)
            {
                TPCamera.SetActive(true);
                FPCamera.SetActive(false);
                isChangeCamera = false;
            }
        }
    }
}
