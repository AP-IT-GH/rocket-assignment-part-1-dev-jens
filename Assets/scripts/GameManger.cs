using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{

    public GameObject Player;
    public GameObject ScoreboardCanvas;
    public GameObject GameOverCanvas;
    private Health healthPlayer;
    public enum GameStates
    {
        Playing,
        GameOver
    }

    public GameStates gameState = GameStates.Playing;
    // Start is called before the first frame update
    void Start()
    {
        if (Player == null)
        {
            Player = GameObject.FindWithTag("Player");
        }

        healthPlayer = Player.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        // state machine of the game 
        switch (gameState)
        {
            case GameStates.Playing:
                if (!healthPlayer.isAlive)
                {
                    gameState = GameStates.GameOver;
                    ScoreboardCanvas.SetActive(false);
                    GameOverCanvas.SetActive(true);
                    
                }
                break;
        }
    }
}
