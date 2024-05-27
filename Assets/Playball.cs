using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playball : MonoBehaviour
{
    Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        
    }

    
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(h, 0, v);

        rigid.AddForce(vec, ForceMode.Impulse);
    }

    public void Jump() {
       
            rigid.AddForce(Vector3.up*30 , ForceMode.Impulse);
        
    }
}
