using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionController : MonoBehaviour
{
    PlayerController playerController;

    private void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            playerController.IsDead = true; 
            playerController._rb.velocity = Vector3.zero;
            StartCoroutine(LoadScene());
        }
        if(collision.gameObject.tag == "Obstacle")
        {
            playerController._canInteract = true;

        }


    }
    IEnumerator LoadScene()
    {

        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(0);


    }
}
