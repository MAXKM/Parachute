using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z <= 19)
        {
            transform.Translate(new Vector3(0, 0, -0.2f));
        }
        else
        {
            StartCoroutine("Firing");
        }
    }

    IEnumerator Firing()
    {
        yield return new WaitForSeconds(2.25f);
        Destroy(this.gameObject);
    }
}
