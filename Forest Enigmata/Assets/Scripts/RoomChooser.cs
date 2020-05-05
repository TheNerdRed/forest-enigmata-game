using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomChooser : MonoBehaviour
{
    [SerializeField] 
    
    private GameObject NextRoom;

    [SerializeField]
    private GameObject destroyThisRoom;
 

    private void OnTriggerEnter(Collider other)
    {
        Destroy(destroyThisRoom);
        Instantiate(NextRoom);
    }
    
}
