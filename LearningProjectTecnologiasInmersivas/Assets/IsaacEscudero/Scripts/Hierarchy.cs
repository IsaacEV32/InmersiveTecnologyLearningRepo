using UnityEngine;

public class Hierarchy : MonoBehaviour
{
    public GameObject goDad;
    public GameObject goChild;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        goChild.transform.SetParent(goDad.transform);
        //goChild.transform.parent = goDad.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))
        {
            Debug.Log(goDad.transform.name + " " + goDad.transform.childCount);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("El nombre del primer hijo" + goDad.transform.GetChild(0).transform.name);
        }
    }
}
