using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceBack : MonoBehaviour
{
    PlayerController controller;
    public float ForcePower;
    void Start()
    {
        controller = FindObjectOfType<PlayerController>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player" && PlayerController.instance._canBounceBack)
        {
            PlayerController.instance._canBounceBack = false;
            controller._rb.AddForce(Vector3.up * ForcePower, ForceMode.Impulse);
        }
    }
}
