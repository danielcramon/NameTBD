using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] Rigidbody2D body;
    [SerializeField] float movespeed;
    [SerializeField] Transform spriteTransform;

    Vector2 moveDir;
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        moveDir = new Vector2(x, y);
        if (x > 0.1f && y > 0.1f || x > 0.1f && y < -0.1f || x < -0.1f && y > 0.1f || x < -0.1f && y < -0.1f)
        {
            moveDir = moveDir * 0.705f;
        }

        if (x != 0 && x < 0)
        {
            spriteTransform.rotation = new Quaternion(0, 1, 0, 0); 
        }
        else if (x != 0 && x > 0)
        {
            spriteTransform.rotation = new Quaternion(0, 0, 0, 1);
        }
    }

    private void FixedUpdate()
    {
        body.velocity = moveDir * movespeed;
    }

    public void SetMovementSpeed(float speed)
    {
        movespeed = speed;
    }
}
