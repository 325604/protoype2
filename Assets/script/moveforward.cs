using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class moveforward : MonoBehaviour
{//hoe snel het projectiel vliegt 
    public float speed = 40.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {//waar de diern naar toe lopen 
       transform.Translate(Vector3.forward * Time.deltaTime * speed); 
    }

    
}
