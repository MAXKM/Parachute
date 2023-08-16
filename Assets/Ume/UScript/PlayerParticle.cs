using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerParticle : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject smoke;
    public GameObject MR;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        Vector3 posi = this.transform.position;
        if (collision.gameObject.CompareTag("Floor"))
        {
            Instantiate(smoke, posi, Quaternion.Euler(0, 180, 0));
        }
    }
}
