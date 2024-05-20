using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Player : MonoBehaviour
{
    public Vector2 inputVec;
    public float speed;
    
    Rigidbody2D rigid;
    SpriteRenderer spriter;
    Animator anim;
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriter = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        // 1. 힘을 준다.
        // rigid.AddForce(inputVec);

        // 2. 속도제어
        // rigid.velocity = inputVec;

        Vector2 nextVec = inputVec * speed * Time.fixedDeltaTime;
        // 3. 위치 이동
        rigid.MovePosition(rigid.position + nextVec);
    }

    void OnMove(InputValue value)
    {
        inputVec = value.Get<Vector2>();
    }

    void LateUpdate()
    {
        anim.SetFloat("Speed", inputVec.magnitude);


        if (inputVec.x != 0) {
            spriter.flipX = inputVec.x < 0;
        }

    }
}
