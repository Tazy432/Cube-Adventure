using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float miscareFata = 2000f;
    public float miscareLaterala = 500f;
   
    void FixedUpdate()//mai bine pt fizica
    {
        rb.AddForce(0, 0, miscareFata * Time.deltaTime);
        if(Input.GetKey("d"))
        {
            rb.AddForce(miscareLaterala*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-miscareLaterala * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y<-1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
