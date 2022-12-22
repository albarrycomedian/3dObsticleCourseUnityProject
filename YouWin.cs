using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWin : MonoBehaviour
{

    float hits = 0.0f;
    private void OnCollisionEnter(Collision other)
    { 
        if(other.gameObject.tag == "Hit");
        {
            hits++;
        }
        if(other.gameObject.tag == "Player");
        {
            Debug.Log("Congratulations, you made it to the end! You only hit " + hits + "objects.");
        }
        
    }
}
