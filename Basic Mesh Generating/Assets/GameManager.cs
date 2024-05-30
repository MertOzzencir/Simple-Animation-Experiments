using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI score;
    public static GameManager instance;
    public bool finishedGame;

    private void Start()
    {
        instance = this;
    }

    void Update()
    {
        if (!finishedGame)
        {
            float scores = Mathf.RoundToInt(Time.time);
            score.text = "SCORE: " + scores.ToString();
        }
        
        
    }
}
