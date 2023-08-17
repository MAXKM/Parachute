using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class CamaraController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    private Vector3 offset;
    private Vector3 PlayerTFP;
    private Vector3 PlayerTFA;
    private Vector3 TTFP;
    private Vector3 TTFA;
    public PlayerController playerController;
    bool onece;
    bool finish;
    float z = 35.0f;
    void Start()
    {
        offset = transform.position - player.transform.position;
        onece = true;
        finish = false;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerTFP = player.transform.position;
        PlayerTFA = player.transform.eulerAngles;
        if(playerController.play == true)
        {
            transform.position = player.transform.position + offset;
        }
        if(playerController.play == false && onece == true)
        {
            if (PlayerTFP.x <= 6.25f)
            {
                transform.position = new Vector3(PlayerTFP.x - 2.45f, PlayerTFP.y + 0.6f, PlayerTFP.z - 3.0f);
                transform.eulerAngles = new Vector3(0, z, 0);
            }
            else
            {
                transform.position = new Vector3(PlayerTFP.x + 2.45f, PlayerTFP.y + 0.6f, PlayerTFP.z - 3.0f);
                transform.eulerAngles = new Vector3(0, -z, 0);
            }
            onece = false;
            StartCoroutine("FinishFiring");
            offset = transform.position - player.transform.position;
        }
        if (finish == true && this.transform.position.z <= 48.0f)
        {
            transform.position = player.transform.position + offset;
        }
        if (finish == true && this.transform.position.z >= 48.0f)
        {
            transform.position = new Vector3(PlayerTFP.x, transform.position.y, transform.position.z);
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        //transform.position = new Vector3(5, 5, 5);
        //transform.eulerAngles = new Vector3(45, 0, 0);
    }
    IEnumerator FinishFiring()
    {
        yield return new WaitForSeconds(2);
        finish = true;
        
    }
}
