using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawMovement : MonoBehaviour
{
    public float speed = 1f;
    public string direction = "down";
    Vector2 move;



    // Update is called once per frame
    void Update()
    {

        switch(direction){
        case "up":
            move = Vector2.up;
            break;
        case "down":
            move = Vector2.down;
            break;
        case "left":
            move = Vector2.left;
            break;
        case "right":
            move = Vector2.right;
            break;
        }

        transform.Translate(move * speed * Time.deltaTime);
        
    }

    void OnCollisionEnter2D(Collision2D col){

        if(col.gameObject.name == "Tilemap_Ground"){
            
            switch(direction){
            case "up":
                direction = "down";
                break;
            case "down":
                direction = "up";
                break;
            case "left":
                direction = "right";
                break;
            case "right":
                direction = "left";
                break;
            } 

         
        }
    }
}
