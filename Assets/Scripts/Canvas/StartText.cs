using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartText : MonoBehaviour
{
    public static bool GameIsPaused;
    public GameObject startText;
    

    void Start()
    {
        GameIsPaused = true;
        Time.timeScale = 0;
    }



    void Update()
    {
        if (GameIsPaused)
        {

            ShowText();
            Time.timeScale = 0;


            if (Input.GetMouseButton(0))
            {
                

                
                GameIsPaused = !GameIsPaused;
                Time.timeScale = 1;

            }


        }
        else if (!GameIsPaused)
        {
            startText.SetActive(false);
            Time.timeScale = 1;

        }

    }

    
    void ShowText()
    {

        startText.SetActive(true);
        
    }
}


