using UnityEngine;

public class CameraChange : MonoBehaviour
{
    [SerializeField] Camera camInicial;
    [SerializeField] Camera camNueva;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        camInicial.gameObject.SetActive(true); 
        camNueva.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
