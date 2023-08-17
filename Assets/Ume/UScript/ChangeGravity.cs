using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGravity : MonoBehaviour
{
    [SerializeField] private Vector3 localGravity;
    private Rigidbody rb;
    [SerializeField] float LimitSpeed;

    // Use this for initialization
    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.useGravity = false; //�ŏ���rigidBody�̏d�͂��g��Ȃ�����
    }

    private void FixedUpdate()
    {
        SetLocalGravity(); //�d�͂�AddForce�ł����郁�\�b�h���ĂԁBFixedUpdate���D�܂����B
        if (rb.velocity.magnitude > LimitSpeed)
        {
            rb.velocity = new Vector3(rb.velocity.x / 1.1f, rb.velocity.y, rb.velocity.z / 1.1f);
        }
    }

    private void SetLocalGravity()
    {
        rb.AddForce(localGravity, ForceMode.Acceleration);
    }
}
