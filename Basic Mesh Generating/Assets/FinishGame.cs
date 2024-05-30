using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGame : MonoBehaviour
{
    public GameObject GameOver;
    PlayerController playerController;
    private void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameOver.SetActive(true);
            playerController._rb.position = new Vector3(107.989998f, 26.75f, 58f);
            playerController._rb.velocity = Vector3.zero;
            playerController._rb.angularVelocity = Vector3.zero;

            GameManager.instance.finishedGame = true;
            PlayerController.instance._gameOver = true;
            
        }
    }

}
