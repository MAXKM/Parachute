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
    bool onece;
    GameObject p1;
    GameObject p2;
    GameObject p3;
    public AudioClip shoot;
    AudioSource audioSource;
    void Start()
    {
        Application.targetFrameRate = 60;
        staging = false;
        onece = true;
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
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
        if (collision.gameObject.CompareTag("Floor") && onece == true)
        {
            Vector3 posi = this.transform.position;
            posi.y = 0.5f;
            transform.position = posi;
            p1 = Instantiate(smoke, new Vector3(posi.x, posi.y - 0.35f, posi.z - 0.50f), Quaternion.Euler(0, 180, 0));
            p2 = Instantiate(MR, new Vector3(posi.x, posi.y + 0.25f, posi.z + 0.15f), Quaternion.Euler(0, 90, 0));
            p3 = Instantiate(MR2, new Vector3(posi.x, posi.y + 0.25f, posi.z), Quaternion.Euler(0, 90, 0));
            rb.constraints = RigidbodyConstraints.FreezePosition;
            audioSource.PlayOneShot(shoot);
            StartCoroutine("Firing");
            staging = true;
            onece = false;
        }
    }
    
    IEnumerator Firing()
    {
        yield return new WaitForSeconds(2.25f);
        rb.constraints = RigidbodyConstraints.None;

        Vector3 force = new Vector3(0.0f, 0.0f, 50.0f);// 力を設定
        rb.AddForce(force, ForceMode.Impulse);// 力を加える
        Destroy(p1);
        Destroy(p2);
        Destroy(p3);
    }

}
