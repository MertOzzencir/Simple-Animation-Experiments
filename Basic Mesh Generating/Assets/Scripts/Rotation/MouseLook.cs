using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    [SerializeField] private float speed = 100f;
    [SerializeField] private Transform player;
    
    void Update()
    {

        float xAxis = Input.GetAxis("Mouse X") * TimeSpeed();
        float yAxis = Input.GetAxis("Mouse Y") * TimeSpeed();

        player.Rotate(Vector3.up * xAxis);
        


    }
    
    float TimeSpeed() => Time.deltaTime * speed;
}


                    

                
