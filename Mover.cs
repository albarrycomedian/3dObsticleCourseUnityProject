using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{


  [SerializeField] float moveSpeed = 10.0f;
  [SerializeField] float rotationSpeed = 10000.0f;

  public float xAngle, yAngle, zAngle;

    // Start is called before the first frame update
    void Start()
    {
      PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
      MovePlayer();
    }

    void PrintInstructions()
    {
      Debug.Log("Welcome to the game");
      Debug.Log("Try to get to the goal without touching anything");
      Debug.Log("Press WASD to get moving");
    }

    void MovePlayer()
    {
      float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
      float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
      
      transform.Translate(xValue,0,zValue);

    }

}
