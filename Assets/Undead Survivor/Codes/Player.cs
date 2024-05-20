using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Player : MonoBehaviour
{
    public Vector2 inputVec;
    public float speed;
    Rigidbody2D rigid;
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // 1. ���� �ش�.
        // rigid.AddForce(inputVec);

        // 2. �ӵ�����
        // rigid.velocity = inputVec;

        Vector2 nextVec = inputVec * speed * Time.fixedDeltaTime;
        // 3. ��ġ �̵�
        rigid.MovePosition(rigid.position + nextVec);
    }

    void OnMove(InputValue value)
    {
        inputVec = value.Get<Vector2>();
    }
}
