using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public PlayerController playerController;

    public GameObject finalScreen;
    public GameObject startScreen;
    public GameObject player;

    public TextMeshProUGUI finalScoreText;
    public TextMeshProUGUI scoreText;

    public int tokenScore;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();

        // Initialises the score to 0 and resets the text counter.
        finalScoreText.text = "Your final score is : ";

        // Initialises the score to 0 and resets the text counter.
        scoreText.text = "Score : " + tokenScore;
    }

    // Update is called once per frame
    void Update()
    {
        // If r is pressed, restart the game.
        if(Input.GetKeyDown(KeyCode.R))
        {
            restartGame();
        }
    }

    public void startGame()
    {
        startScreen.SetActive(false);
        player.SetActive(true);
    }

    // When this method is called and passed a parameter of the score to update, it updates by that amount.
    public void updateScore(int scoreToAdd)
    {
        tokenScore += scoreToAdd;
        scoreText.text = "Score : " + tokenScore;
    }

    public void endGame()
    {
        playerController.stopMoving();

        finalScoreText.text = finalScoreText.text + tokenScore;

        finalScreen.SetActive(true);
    }

    // When this method is called, it restarts the game and loads from scratch.
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
