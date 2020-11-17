using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingCharacter : MonoBehaviour
{

    public GameObject player;
    public GameObject Normal;

    [HideInInspector]
    public Vector3 playerCoords;

    //public float currentAngleY = 0;
    //public float currentAngleX = 0;
    //public float radius = 1;
    //public float lifting = 0;
    //public float Speed = 1;

    //[HideInInspector]
    //public float radAngleY;

    //[HideInInspector]
    //public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        //rb = player.GetComponent<Rigidbody>();
        //playerCoords = player.transform.position;
        //playerCoords = player.transform.position;
        //radAngleY = currentAngleY * (float)(Math.PI) / 180;
        //transform.position = Vector3.Lerp(transform.position,
        //    (playerCoords - new Vector3((float)Math.Sin(radAngleY), lifting * (-1), (float)Math.Cos(radAngleY)) * radius),
        //    Speed * Time.deltaTime);
        //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(currentAngleX, currentAngleY, 0), Speed * Time.deltaTime);
        transform.position = Normal.transform.position;
        transform.rotation = Normal.transform.rotation;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Linecast(Normal.transform.position, player.transform.position, out hit))
        {
            transform.position = new Vector3(hit.point.x, Normal.transform.position.y, hit.point.z);
        }
        else
        {
            transform.position = Normal.transform.position;
        }
    }
}
