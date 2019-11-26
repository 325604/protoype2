using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrols : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 15.0f;
    public float xRange = 15.0f;

    public GameObject projectilePrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {//hier staat tot hoe ver je kan bewegen
        if (transform.position.x < -xRange)
        {
           transform.position = new Vector3(-xRange, transform.position.y, transform.position.z); 
        }
        
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z); 
        }
        //hier staat de snelheid vermeld
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed); 
        //hier staat als als je space drukt dat het projectiel vliegt
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        
    }
}
