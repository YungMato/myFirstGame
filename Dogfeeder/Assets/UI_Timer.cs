using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UI_Timer : MonoBehaviour
{
    public bool endScreen = false;

    private float timer;

    private bool counterOn;

    
    // Start is called before the first frame update
    void Start()
    {
       DontDestroyOnLoad(gameObject);
        counterOn = true;
    }

    void Update(){

        if(counterOn == true){

            timer += Time.deltaTime;
            UpdateTimerDisplay(timer);
       }

       if(counterOn == false){

            LastTimerUpdate(timer);
            Destroy(this.gameObject.GetComponent<TMPro.TextMeshProUGUI>());
       }

       if(endScreen == true){

            counterOn = false;
       }

       
    }

    // Update is called once per frame
    void UpdateTimerDisplay(float time)
    {
        float seconds = Mathf.FloorToInt(time % 60);
        float fraction = timer * 1000;
        fraction = fraction % 1000;

        string currentTime = "Time: " + string.Format("{0:00}:{1:000}", seconds,fraction);
        this.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = currentTime.ToString();
    }

    void LastTimerUpdate(float time){

        float seconds = Mathf.FloorToInt(time % 60);
        float fraction = timer * 1000;
        fraction = fraction % 1000;

        string currentTime = string.Format("{0:00}:{1:000}", seconds,fraction);
        GameObject.FindWithTag("Finish").GetComponent<TMPro.TextMeshProUGUI>().text = currentTime.ToString();
        
    }





}
