using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneInfo : MonoBehaviour
{
    [SerializeField]
    private int id;

    private Dictionary<int,GameObject> planesOnRadar;

    // Start is called before the first frame update
    /*void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Plane")
        {
            planesOnRadar.Add(collision.gameObject.GetInstanceID(), collision.gameObject);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Plane")
        {
            planesOnRadar.Remove(collision.gameObject.GetInstanceID());
        }
    }
}
