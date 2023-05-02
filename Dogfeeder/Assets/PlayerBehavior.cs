using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerBehavior : MonoBehaviour
{

    bool hasBone = false;
    public TextMesh Instruction;

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col){

        if(col.gameObject.name == "Bone"){
            Destroy(col.gameObject);
            hasBone = true;
            FindObjectOfType<AudioManager>().Play("boneCollected");
            Text instruction = GetComponent<Text>();
            instruction.text = "Text";
        }

        if(col.gameObject.name == "Dog"){

            if(hasBone){
                FindObjectOfType<AudioManager>().Play("levelWon");
                NextLevel();
            } else {
                Debug.Log("Hol den Knochen");
                FindObjectOfType<AudioManager>().Play("noBone");
            }
        }

        if(col.gameObject.name == "Saw"){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        
    }

    public void NextLevel(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
