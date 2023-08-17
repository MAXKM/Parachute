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
    public GameObject MR2;
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
            Instantiate(smoke, new Vector3(posi.x, posi.y - 0.35f, posi.z - 0.50f), Quaternion.Euler(0, 180, 0));
            Instantiate(MR, new Vector3(posi.x, posi.y + 0.25f, posi.z + 0.15f), Quaternion.Euler(0, 90, 0));
            Instantiate(MR2, new Vector3(posi.x, posi.y + 0.25f, posi.z), Quaternion.Euler(0, 90, 0));
        }
        rb.constraints = RigidbodyConstraints.FreezePosition;
        posi.y = -1.63f;
        transform.position = posi;
        staging = true;
    }


}
