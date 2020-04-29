using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenCollection : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
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
            Debug.Log("Player has collided with token!");
            Destroy(gameObject);
        }
    }
}
