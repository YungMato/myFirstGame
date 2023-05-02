using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 4;
    Vector2 move;

    // Update is called once per frame
    void FixedUpdate()
    {
        
        move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        transform.Translate(move * speed * Time.deltaTime);
    }

    
}
