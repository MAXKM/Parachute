using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float RLUD;
    public float BR;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //�E�ɓ������v���O����
        if (Input.GetKey(KeyCode.A) == true || Input.GetKey(KeyCode.LeftArrow) == true)
        {
            transform.Translate(new Vector3(-RLUD, 0, 0), Space.World);
        }
        //���ɓ������v���O����
        if (Input.GetKey(KeyCode.D) == true || Input.GetKey(KeyCode.RightArrow) == true)
        {
            transform.Translate(new Vector3(RLUD, 0, 0), Space.World);
        }
        //��ɓ������v���O����
        if (Input.GetKey(KeyCode.W) == true || Input.GetKey(KeyCode.UpArrow) == true)
        {
            transform.Translate(new Vector3(0, 0, RLUD), Space.World);
        }
        //���ɓ������v���O����
        if (Input.GetKey(KeyCode.S) == true || Input.GetKey(KeyCode.DownArrow) == true)
        {
            transform.Translate(new Vector3(0, 0, -RLUD), Space.World);
        }
        //�{�[������]������
        Transform myTransform = this.transform;
        Vector3 worldAngle = myTransform.eulerAngles;
        worldAngle.x += BR;
        myTransform.eulerAngles = worldAngle; // ��]�p�x��ݒ�
    }
}
