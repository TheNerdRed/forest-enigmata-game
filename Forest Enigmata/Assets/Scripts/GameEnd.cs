using UnityEngine;

public class GameEnd : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameManager.endGame();
        }
    }
}
