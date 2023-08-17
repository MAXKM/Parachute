using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    void Start()
    {
        StartCoroutine("StartFiring");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator StartFiring()
    {
        yield return new WaitForSeconds(3);
        rb = GetComponent<Rigidbody>();
        Vector3 force = new Vector3(0.0f, 100.0f, 0.0f);// óÕÇê›íË
        rb.AddForce(force, ForceMode.Impulse);// óÕÇâ¡Ç¶ÇÈ
    }
}
