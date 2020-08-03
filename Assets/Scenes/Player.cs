using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
     float speed = 1.0f;

     void Update()
     {
        var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        if((move.x !=0 || move.y != 0) && speed < 25.0f) {
            speed += 1.0f;
        }
        else{
            speed = 1.0f;
        }
        transform.position += move * speed * Time.deltaTime;
     }
}
