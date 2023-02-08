using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    
    public float velocidad = 1.0f;
    new Rigidbody rigidbody;
    

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        
    }

    private void FixedUpdate()
    {
        float f = Input.GetAxis("Horizontal");
        rigidbody.velocity = Vector3.up * rigidbody.velocity.y + Vector3.right * f * velocidad;
    }

  
    // Update is called once per frame
    void Update()
    {   

        
    }
}
