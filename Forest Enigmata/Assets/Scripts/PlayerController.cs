using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 20f;
    public float verticalInput;
    public float horizontalInput;

    public bool canMove = true;

    // Start is called before the first frame update
    void Start()
    {
        canMove = true;
    }

    // Update is called once per frame
    void Update()
    {

        if(canMove)
        {
            // Axis setup
            verticalInput = Input.GetAxis("Vertical");
            horizontalInput = Input.GetAxis("Horizontal");

            transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
            transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        }
    }

    public void stopMoving()
    {
        canMove = false;
    }
}
