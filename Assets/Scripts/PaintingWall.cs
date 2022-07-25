using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class PaintingWall : MonoBehaviour
{
    /*public MeshRenderer meshRenderer;
    public Texture2D brush;
    public Vector2Int textureArea;
    Texture2D texture;
   
    void Start()
    {
        texture = new Texture2D(textureArea.x, textureArea.y, TextureFormat.ARGB32, false);
        meshRenderer.material.mainTexture = texture;

        
    }
    
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            RaycastHit hitInfo;
            if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo))
            {
                Debug.Log(hitInfo.textureCoord);
                Paint(hitInfo.textureCoord);
            }
        }


    }


    private void Paint(Vector2 coordinate)
    {
        coordinate.x *= texture.width;
        coordinate.y *= texture.height;

        Vector2Int halfBrush = new Vector2Int(brush.width / 2, brush.height / 2);

        for(int x = 0; x < brush.width; x++)
        {
            for(int y = 0; y < brush.height; y++)
            {
                if(brush.GetPixel(x,y).a > 0f)
                {
                    Color textureRengi = texture.GetPixel(
                        (int)coordinate.x + (halfBrush.x - x),
                        (int)coordinate.y + (halfBrush.y - y));


                    if (brush.GetPixel(x, y).r < textureRengi.r)
                    {


                        texture.SetPixel(
                            (int)coordinate.x + (halfBrush.x - x),
                            (int)coordinate.y + (halfBrush.y - y),
                            brush.GetPixel(x, y));
                    }
                    }
            }
        }

        texture.Apply();
    }*/

    //--------------------------------------------------------------------------------------------------------------


    public GameObject Brush;

    public float BrushSize = 1f;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetMouseButton(1))
        {
            var Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if(Physics.Raycast(Ray, out hitInfo))
            {
                var go = Instantiate(Brush, hitInfo.point + Vector3.up * 0.1f, Quaternion.identity, transform);
                go.transform.localScale = Vector3.one * BrushSize;
            }


        }
       }
    }

