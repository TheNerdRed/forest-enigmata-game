using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public int tokenScore;

    // Start is called before the first frame update
    void Start()
    {
        // Initialises the score to 0 and resets the text counter.
        tokenScore = 0;
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
     
    // When this method is called, it restarts the game and loads from scratch.
    void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // When this method is called and passed a parameter of the score to update, it updates by that amount.
    public void updateScore(int scoreToAdd)
    {
        tokenScore += scoreToAdd;
        scoreText.text = "Score : " + tokenScore;
    }
}
