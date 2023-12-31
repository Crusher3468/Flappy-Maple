using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground_0 : MonoBehaviour
{
    public bool Camera_Move;
    public float Camera_MoveSpeed = 1.5f;
    [Header("Layer Setting")]
    public float[] Layer_Speed = new float[7];

    private Transform _camera;
    private float[] startPos = new float[7];
    private float boundSizeX;
    private float sizeX;
    private GameObject Layer_0;
    void Start()
    {
        _camera = Camera.main.transform;
        for (int i=0;i<5;i++){
            startPos[i] = _camera.position.x;
        }
    }

    void Update(){
        //Moving camera
        if (Camera_Move){
        _camera.position += Vector3.right * Time.deltaTime * Camera_MoveSpeed;
        }
        for (int i=0;i<5;i++){
            float temp = (_camera.position.x * (1-Layer_Speed[i]) );
            float distance = _camera.position.x  * Layer_Speed[i];
            if (temp > startPos[i] + boundSizeX*sizeX){
                startPos[i] += boundSizeX*sizeX;
            }else if(temp < startPos[i] - boundSizeX*sizeX){
                startPos[i] -= boundSizeX*sizeX;
            }
            
        }
    }
}
