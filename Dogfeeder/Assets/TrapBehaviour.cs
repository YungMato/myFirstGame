using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapBehaviour : MonoBehaviour
{
    public Sprite sprite1; // Hole
    public Sprite sprite2; // Shark
    public SpriteRenderer spriteRenderer;
    public int speed = 1000;
    int changeTimer = 0;
    

    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        if(changeTimer > speed){
            changeSprite();
            changeTimer = 0;
        } else {
            changeTimer++;
        }
        
    }

    void changeSprite(){
        
        if(spriteRenderer.sprite == sprite1){
            spriteRenderer.sprite = sprite2;
            this.gameObject.AddComponent<BoxCollider2D>();
        } else if(spriteRenderer.sprite == sprite2) {
            spriteRenderer.sprite = sprite1;
            Destroy(this.gameObject.GetComponent<BoxCollider2D>());
        }
    }

    

}
