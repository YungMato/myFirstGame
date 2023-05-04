using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreen : MonoBehaviour
{   
    float speed = 2f;
    float time = 1f;
    Vector2 move1 = Vector2.right;
    Vector2 move2 = Vector2.left;
    bool heartSpawned = false;

    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Stop("bgm");
        GameObject.Find("Timer").GetComponent<UI_Timer>().endScreen = true;
        
        
    }

    // Update is called once per frame
    void Update()
    {
       

        GameObject.Find("Obj1").transform.Translate(move1 * speed * Time.deltaTime);
        GameObject.Find("Obj2").transform.Translate(move2 * speed * Time.deltaTime);        

        time = time + Time.deltaTime;

        if(time > 4.6f){
            move1 = new Vector2(0,0);
            move2 = new Vector2(0,0);

            if(heartSpawned == false){
                GameObject.Find("Heart").GetComponent<SpriteRenderer>().sortingOrder = 4;
                FindObjectOfType<AudioManager>().Play("endHeart");
                heartSpawned = true;
            }
        }
            
    }

}
