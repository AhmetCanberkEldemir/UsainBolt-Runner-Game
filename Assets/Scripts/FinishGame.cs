using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGame : MonoBehaviour
{
    bool anahtar = false;
    

    
    void Update()
    {
        if (anahtar)
        {
        CharacterController.instance._currentRunSpeed = 0;

            

        }
           
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            
            anahtar = true;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            
        }
    }
}
