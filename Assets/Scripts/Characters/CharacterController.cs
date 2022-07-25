using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public static CharacterController instance; //Diðer scriptlerden eriþim için

    public float limitX; //X Ekseninde karakterin hareket edebildiði maksimum ve minimum deðerleri tutacak
    public float newX = 0; //X Ekseninde hareket
    //float newZ = 0; //Y Ekseninde hareket
    //public float limitZ;
    float xDelta = 0; //Mouse sol týk datasýný tutsun
    public float XSpeed; //X Eksenindeki hareket hýzý

    //public float runSpeed; //Karakter koþma hýzý
    public float _currentRunSpeed; //Anlýk karakter hýzý

    public Animator anim;

    

    void Start()
    {
        //_currentRunSpeed = runSpeed; // Ayarlanan hýza eþit olsun
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
                                                                                                                                   //karakterin hýzýyla hareket ettirerek
                                                                                                                                   //ilerlemiþ oluyor.

        transform.position = newPosition;


        if (Input.GetMouseButton(0)) //Eðer mousenin Sol týkýna basýldýysa,
        {
            

            xDelta = Input.GetAxis("Mouse X"); //Mouse sol týkýn hareket deðiþimini tutsun
            newX = transform.position.x + XSpeed * xDelta * Time.deltaTime * 0.5f; //Ne kadar X ekseninde mouse ile hareket ettiysek bunu hareket hýzýyla ve zamanla çarparak
                                                                                   //bize karakterimizin X eksenindeki yeni pozisyonunu saðlasýn

            newX = Mathf.Clamp(newX, -limitX, limitX); //Proje normalinde Render'ý kapalý duvarlar ekleyecektim,
                                                       //bu yöntem daha pratik geldi. Mathf kütüphanesinden limitX deðerimizin min ve max deðerinde hareket ettiriyor.
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
