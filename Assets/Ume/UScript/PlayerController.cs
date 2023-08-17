using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float RLUD;
    public float BR;
    public bool play;
    void Start()
    {
        play = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(play == true)
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
        }
        //�{�[������]������
        Transform myTransform = this.transform;
        myTransform.Rotate(BR, 0, 0, Space.World);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            BR = 0;
            play = false;
        }
    }
}
