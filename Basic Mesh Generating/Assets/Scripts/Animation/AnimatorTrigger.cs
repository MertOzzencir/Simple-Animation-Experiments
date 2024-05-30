using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorTrigger : MonoBehaviour
{
    Animator animator;
    public string parameter;


    private void Start()
    {
        animator = GetComponent<Animator>();
    }


  
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            animator.SetTrigger(parameter);

        }
    }


}
