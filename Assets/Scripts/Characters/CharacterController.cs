using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public static CharacterController instance; //Di�er scriptlerden eri�im i�in

    public float limitX; //X Ekseninde karakterin hareket edebildi�i maksimum ve minimum de�erleri tutacak
    public float newX = 0; //X Ekseninde hareket
    //float newZ = 0; //Y Ekseninde hareket
    //public float limitZ;
    float xDelta = 0; //Mouse sol t�k datas�n� tutsun
    public float XSpeed; //X Eksenindeki hareket h�z�

    //public float runSpeed; //Karakter ko�ma h�z�
    public float _currentRunSpeed; //Anl�k karakter h�z�

    public Animator anim;

    

    void Start()
    {
        //_currentRunSpeed = runSpeed; // Ayarlanan h�za e�it olsun
        anim = GetComponent<Animator>();
       
    }
    public void Awake() //Bir tane daha varsa Destroy et
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        Vector3 newPosition = new Vector3(newX, transform.position.y, transform.position.z + (_currentRunSpeed * Time.deltaTime)); //Sadece Z ekseninde
                                                                                                                                   //karakterin h�z�yla hareket ettirerek
                                                                                                                                   //ilerlemi� oluyor.

        transform.position = newPosition;


        if (Input.GetMouseButton(0)) //E�er mousenin Sol t�k�na bas�ld�ysa,
        {
            

            xDelta = Input.GetAxis("Mouse X"); //Mouse sol t�k�n hareket de�i�imini tutsun
            newX = transform.position.x + XSpeed * xDelta * Time.deltaTime * 0.5f; //Ne kadar X ekseninde mouse ile hareket ettiysek bunu hareket h�z�yla ve zamanla �arparak
                                                                                   //bize karakterimizin X eksenindeki yeni pozisyonunu sa�las�n

            newX = Mathf.Clamp(newX, -limitX, limitX); //Proje normalinde Render'� kapal� duvarlar ekleyecektim,
                                                       //bu y�ntem daha pratik geldi. Mathf k�t�phanesinden limitX de�erimizin min ve max de�erinde hareket ettiriyor.
        }


        if(_currentRunSpeed == 0)
        {
            anim.SetBool("running", false);

        }
        else if(_currentRunSpeed == 1)
        {
            anim.SetBool("running", true);
        }






        







        /*newZ = transform.position.z;
        newZ = Mathf.Clamp(newZ, -limitZ, limitZ);

        if (newZ >= 20)
        {
            runSpeed == 0;
        }*/
    }

    
}
