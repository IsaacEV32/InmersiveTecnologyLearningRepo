using UnityEngine;

public class InstantiateCube : MonoBehaviour
{
    [SerializeField]GameObject sphere;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.transform.position = new Vector3(1,1,1);
    }

    private void OnMouseDown()
    {
        Instantiate(sphere, new Vector3(2,2,2), Quaternion.identity);
    }
}
