using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerParticle : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public GameObject smoke;
    public GameObject MR;
    public float BR;
    bool staging;
    void Start()
    {
        staging = false;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(staging == true)
        {
            Transform myTransform = this.transform;
            myTransform.Rotate(BR, 0, 0, Space.World);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        Vector3 posi = this.transform.position;
        if (collision.gameObject.CompareTag("Floor"))
        {
            Instantiate(smoke, posi, Quaternion.Euler(0, 180, 0));
        }
        rb.constraints = RigidbodyConstraints.FreezePosition;
        posi.y = -1.55f;
        transform.position = posi;
        staging = true;
    }
}
