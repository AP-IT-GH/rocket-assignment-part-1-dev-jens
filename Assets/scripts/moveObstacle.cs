using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObstacle : MonoBehaviour
{   
    
    public GameObject obstacle;
    public float speed;

    public void Update()
    {
        float y = Mathf.PingPong(Time.time * speed, 1) *3+4;
        obstacle.transform.position = new Vector3(transform.position.x, y, transform.position.z);
    }
}
