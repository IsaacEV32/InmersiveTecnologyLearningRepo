using UnityEngine;

public class Spotlight : MonoBehaviour
{
    [SerializeField]Transform arrow;
    [SerializeField]GameObject spot;
    bool isActivated = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spot.transform.LookAt(arrow);
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (isActivated)
            {
                isActivated = false;
                spot.gameObject.SetActive(false);
            }
            else if (!isActivated)
            {
                isActivated = true;
                spot.gameObject.SetActive(true);
            }
        }
    }
}
