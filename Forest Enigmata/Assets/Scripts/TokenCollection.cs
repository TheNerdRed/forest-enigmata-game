using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenCollection : MonoBehaviour
{
    // References the Game Manager class, so methods from within can be used.
    public GameManager gameManager;

    public GameObject player;

    public int minimumScore = 3;
    public int maximumScore = 9;
    public int randomScore;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            randomScore = Random.Range(minimumScore, maximumScore);

            gameManager.updateScore(randomScore);
            Destroy(gameObject);
        }
    }
}
