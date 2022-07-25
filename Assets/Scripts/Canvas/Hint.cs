using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Hint : MonoBehaviour
{
   
    public GameObject hintText;
    public GameObject levelText;

   

    private void Start()
    {
        hintText.SetActive(true);
        
        InvokeRepeating("IkiSaniyeBekle", 3,0);

        levelText.SetActive(true);
        
        InvokeRepeating("UcSaniyeBekle", 3, 0);

    }

    void IkiSaniyeBekle()
    {
        
           hintText.SetActive(false);
           

    }
    void UcSaniyeBekle()
    {
        
        levelText.SetActive(false);


    }
    
}
