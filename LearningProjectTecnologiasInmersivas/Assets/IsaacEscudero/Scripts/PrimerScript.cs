using UnityEngine;

public class PrimerScript : MonoBehaviour
{
    [SerializeField] private string nombre = "Isaac";
    public GameObject miObjeto;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hola " + nombre);

        miObjeto.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
