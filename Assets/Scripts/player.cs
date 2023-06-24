using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class player : MonoBehaviour
{
    [SerializeField]float speed = 5.0f;
    Vector2 minBounds;
    Vector2 maxBounds;
    Vector2 rawInput;
    [SerializeField] float moveSpeed = 0.01f;
     
    void Update()
    {
        move();
    }
    void move()
    {
        Vector3 delta = rawInput * moveSpeed * Time.deltaTime;
        transform.position += delta;
    }
    

}

