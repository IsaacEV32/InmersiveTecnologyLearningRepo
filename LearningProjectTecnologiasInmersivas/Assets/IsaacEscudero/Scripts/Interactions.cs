using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class Interactions : MonoBehaviour
{
    GameObject values;
    Values v;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        values = GameObject.Find("Values");
        v = values.GetComponent<Values>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            Debug.Log("Estoy upeando");
        }
        else if (Input.GetKeyDown("down"))
        {
            Debug.Log("Estoy downeando");
        }
        else if (Input.GetKeyUp(KeyCode.L))
        {
            Debug.Log("Estoy eleando");
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            Debug.Log("Nombre: " + v.nombre + " Password: " + v.password);
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            GameObject.Find("Hijo").GetComponent<MeshRenderer>().material.color = Color.red;
            Debug.Log("Cambio");
        }
    }
}
