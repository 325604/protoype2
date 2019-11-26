using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delectcollies : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
        {//hier wordt vemeld dat het opject wordt vewijdererd
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
}
