using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayGame(){

        FindObjectOfType<AudioManager>().Play("gameStart");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
