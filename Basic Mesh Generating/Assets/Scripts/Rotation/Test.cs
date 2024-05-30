using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test : MonoBehaviour
{
    Vector3 rotate;
    [Range(0f, 1f)]
    public float x;
    [Range(0f, 1f)]
    public float y;
    [Range(0f, 1f)]
    public float z;
    [Range(0f, 1f)]
    public float w;
    [Range(0f, 1f)]
    public float t;

    public float speed = 8f;

    [SerializeField] private Transform Target;
    void Start()
    {
    }

    void Update()
    {
        //rotate += new Vector3(x, y, z);
        //transform.rotation = Quaternion.Euler(rotate);

        //


        //rotate += new Vector3(x, y, z); 
        //transform.eulerAngles = new Vector3(x, y, z);


        //

        //Vector3 direction = (Target.position - transform.position).normalized; 
        //transform.rotation = Quaternion.LookRotation(direction);




        //





        //Vector3 direction = (Target.position - transform.position); 
        //if (Target.position.y < 1.5f && Target.position.y > -.1f) { 
        //direction.y = 0; 
        //Quaternion rotation = Quaternion.LookRotation(direction); 
        //transform.rotation = Quaternion.Slerp(transform.rotation, rotation, t);
        //}


        //



        //Vector3 input = new Vector3(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"), 0);
        //transform.rotation *= Quaternion.Euler(input);

    }
}
