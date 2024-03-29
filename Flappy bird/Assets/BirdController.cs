using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float JumpForse;
    public Rigidbody2D Rigidbody2D;
    void Start()
    {
        
    }

   
    void Update()
    {
       if(Input.GetButtonDown("Jump"))
        {
            Rigidbody2D.AddForce(new Vector2(0, JumpForse), ForceMode2D.Impulse);
        }
    }
}
