using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class RotatorStick : MonoBehaviour
{
    public Rigidbody rigid;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "RotatorStick")
        {
            transform.DOMoveZ(-0.05f, 0.1f); //Vurduðunda karaktere güç uygulasýn, transformunu deðiþtirsin

           


        }
    }
}
