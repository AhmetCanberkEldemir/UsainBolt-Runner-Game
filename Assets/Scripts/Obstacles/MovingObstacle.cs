using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovingObstacle : MonoBehaviour

{
    


    public float speed; //Objenin hareket h�z� buradan belirlenecek

    public Vector3 startPos1; //Ba�lang�� pozisyonu ald�m
    public Vector3 startPos2; //Biti� pozisyonu ald�m


    public Transform currentPoint; //Objenin anl�k konumu
    public GameObject platform; //Hareket edecek nesnemiz

    void Start()
    {
        startPos1 = platform.transform.position;
    }


    void Update()
    {
        platform.transform.position = Vector3.MoveTowards(platform.transform.position, startPos1, Time.deltaTime * speed); //Ba�lang�� pozisyonundan platformun hareketini sa�la

        if (platform.transform.position == startPos1) //E�er platform birinci belirledi�imiz pozisyondaysa ikinci pozisyona e�itle, bu da hareketimizi sa�layacak
        {
            startPos1 = startPos2;
            if (startPos1 == startPos2) //Platformumuz ula��nca yeni pozisyonumuzu ayarla
            {
                startPos2 = platform.transform.position;

            }

        }



    }
}



