using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    public Joystick joystick;
    public GameObject player;
    public Moving playerMoving;

    void Start()
    {
        joystick = GetComponent<Joystick>();
        playerMoving = player.GetComponent<Moving>();
    }

    // Update is called once per frame
    void Update()
    {
        //If joystick shifted on O(x)
        if (joystick.Horizontal > 0.1f)
        {
            playerMoving.shiftX = 1;
        }
        else if (joystick.Horizontal < -0.1f)
        {
            playerMoving.shiftX = -1;
        }
        else
        {
            playerMoving.shiftX = 0;
        }
        //If joystick shifted on O(y)
        if (joystick.Vertical > 0.1f)
        {
            playerMoving.shiftZ = 1;
        }
        else if (joystick.Vertical < -0.1f)
        {
            playerMoving.shiftZ = -1;
        }
        else
        {
            playerMoving.shiftZ = 0;
        }
    }
}
