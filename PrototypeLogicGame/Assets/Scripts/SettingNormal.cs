using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingNormal : MonoBehaviour
{
    public float lifting;
    public float radius;
    public float angleX;
    public GameObject player;


    // Start is called before the first frame update
    void Awake()
    {
        transform.position -= new Vector3(0, (-1) * lifting, radius);
        transform.rotation = Quaternion.Euler(angleX, player.transform.rotation.y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
