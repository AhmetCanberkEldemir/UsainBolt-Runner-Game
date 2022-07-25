using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovingObstacle : MonoBehaviour

{
    


    public float speed; //Objenin hareket hýzý buradan belirlenecek

    public Vector3 startPos1; //Baþlangýç pozisyonu aldým
    public Vector3 startPos2; //Bitiþ pozisyonu aldým


    public Transform currentPoint; //Objenin anlýk konumu
    public GameObject platform; //Hareket edecek nesnemiz

    void Start()
    {
        startPos1 = platform.transform.position;
    }


    void Update()
    {
        platform.transform.position = Vector3.MoveTowards(platform.transform.position, startPos1, Time.deltaTime * speed); //Baþlangýç pozisyonundan platformun hareketini saðla

        if (platform.transform.position == startPos1) //Eðer platform birinci belirlediðimiz pozisyondaysa ikinci pozisyona eþitle, bu da hareketimizi saðlayacak
        {
            startPos1 = startPos2;
            if (startPos1 == startPos2) //Platformumuz ulaþýnca yeni pozisyonumuzu ayarla
            {
                startPos2 = platform.transform.position;

            }

        }



    }
}



