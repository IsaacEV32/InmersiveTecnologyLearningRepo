using UnityEngine;

public class Transformate : MonoBehaviour
{
    public int velocidad;
    public int velocidadRotacion;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.back * velocidad * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            this.transform.Rotate(Vector3.up * velocidadRotacion * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            this.transform.Rotate(Vector3.down * velocidadRotacion * Time.deltaTime);
        }
    }
}
