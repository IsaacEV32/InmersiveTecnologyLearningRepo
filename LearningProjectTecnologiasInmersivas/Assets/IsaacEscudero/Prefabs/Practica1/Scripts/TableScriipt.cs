using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class TableScriipt : MonoBehaviour
{
    [SerializeField] GameObject table;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 2; i++)
        {
            Instantiate(table);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log(GameObject.FindGameObjectsWithTag("Table"));
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            GameObject[] childs = GameObject.FindGameObjectsWithTag("Table");
            foreach (GameObject child in childs)
            {
                child.GetComponent<MeshRenderer>().material.color = Color.green;
            }
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            GameObject[] fathers = GameObject.FindGameObjectsWithTag("Table");

            foreach (GameObject g in fathers)
            {
                for (int i = 0; i < g.transform.childCount; i++)
                {
                    Transform child = g.transform.GetChild(i);
                    Debug.Log(child.transform.position);
                }
            }

        }
    }
}
