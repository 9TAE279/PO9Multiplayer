using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Unity.VisualScripting;
using UnityEngine;

public class MouseStance : MonoBehaviour
{
    public Vector2 turn;
    public string stance;
    [SerializeField] private float turnSensitive;
    [SerializeField] private float sensitive = 1;



    enum StanceDirection
    {
        Left, Right, Up
    }
    [SerializeField] private StanceDirection stanceDirection;

    void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        turn.x = Input.GetAxis("Mouse X");
        turn.y = Input.GetAxis("Mouse Y");
        Stance();


    }

    public void Stance()
    {
        if (turn.y > 1 * sensitive)
        {
            stanceDirection = StanceDirection.Up;
            stance = "Up";
        }
        else if (turn.x > 1 * sensitive)
        {
            stanceDirection = StanceDirection.Right;
            stance = "Right";
        }
        else if (turn.x < -1 * sensitive)
        {
            stanceDirection = StanceDirection.Left;
            stance = "Left";
        }
        if (stanceDirection == StanceDirection.Up)
        {
          
        }
    }

    void PlayerIsnotSelf() 
    {

    }
  
}
