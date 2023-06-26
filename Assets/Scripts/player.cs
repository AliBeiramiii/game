using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class player : MonoBehaviour
{
    [SerializeField] float moveSpead = 5f;
    Vector2 rawInput;
    [SerializeField] float paddingLeft;
    [SerializeField] float paddingRight;
    [SerializeField] float paddingTop;
    [SerializeField] float paddingBotton;
    Shooter shooter;

    Vector2 minBounds;
    Vector2 maxBounds;
    void Awake()
    {
        shooter = GetComponent<Shooter>();
    }
    void Start()
    {
        initBounds();
    }
    void Update()
    {
        move();
    }
    void initBounds()
    {
        Camera mainCamera = Camera.main;
        minBounds = mainCamera.ViewportToWorldPoint(new Vector2(0, 0));
        maxBounds = mainCamera.ViewportToWorldPoint(new Vector2(1, 1));
    }
    void move()
    {
        Vector3 delta = rawInput * moveSpead * Time.deltaTime;
        Vector2 newPos = new Vector2();
        newPos.x = Mathf.Clamp(transform.position.x + delta.x, minBounds.x + paddingLeft, maxBounds.x - paddingRight);
        newPos.y = Mathf.Clamp(transform.position.y + delta.y, minBounds.y + paddingBotton, maxBounds.y - paddingTop);
        transform.position = newPos;
    }
    void OnMove(InputValue value)
    {
        rawInput = value.Get<Vector2>();

    }
    // void onFire(InputAction value)  
    //{
    //  if (shooter != null)
    //{
    //   shooter.isFiring = value.IsPressed();
    //}
    //}
}
