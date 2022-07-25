using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Rotate : MonoBehaviour
{
    public Vector3 rotateDir;
    public float speed;
    


    
    void Start()
    {
        
    }

   
    void Update()
    {

      transform.Rotate(rotateDir * 0.02f);


     
       

    }

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {

            

            CharacterController.instance.newX += -speed * Time.deltaTime; //Karaktere X Düzleminde ters etki etsin



        }
    }

    
}
