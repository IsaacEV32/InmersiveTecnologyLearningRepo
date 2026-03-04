using UnityEngine;

public class InstantiateAndDestroy : MonoBehaviour
{
    public GameObject miGameObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            GameObject.CreatePrimitive(PrimitiveType.Sphere);
            GameObject miCubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
            miCubo.transform.position = new Vector3(2, 2, 2);
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            Instantiate(miGameObject);
        }

            
    }
}
