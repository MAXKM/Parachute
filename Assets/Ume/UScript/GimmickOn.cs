using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GimmickOn : MonoBehaviour
{
    // Start is called before the first frame update
    bool on;
    public GameObject Gk;
    public PlayerController playerController;
    public CamaraController camaraController;
    void Start()
    {
        on = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y >= 1000 && on == false)
        {
            Gk.SetActive(true);
        }
    }
}
