using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorTriggerCollision : MonoBehaviour
{
    Animator animator;
    public string parameter;


    private void Start()
    {
        animator = GetComponent<Animator>();
    }



   

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            animator.SetTrigger(parameter);

        }
    }


}
