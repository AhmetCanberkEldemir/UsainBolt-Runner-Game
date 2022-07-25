using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoStart : MonoBehaviour
{
    public static bool GameIsPaused;
    public GameObject trapsText;
    public GameObject deadMenuUI;

    void Update()
    {
        if (GameIsPaused)
        {

            deadMenuUI.SetActive(true);
            Time.timeScale = 0;


            if (Input.GetKeyDown(KeyCode.R))
            {
              

                SceneManager.LoadScene(0);
                GameIsPaused = !GameIsPaused;

            }


            if (Input.GetKeyDown(KeyCode.Q))
            {
                Application.Quit();
            }

        }
        else if (!GameIsPaused)
        {
            deadMenuUI.SetActive(false);
            Time.timeScale = 1;

        }

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag ("Obstacles"))
        {
            GameIsPaused = !GameIsPaused;

            Update();

            trapsText.SetActive(true);
        }
    }
    void ShowText()
    {
        
        trapsText.SetActive(false);
    }
}
