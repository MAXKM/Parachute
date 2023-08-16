using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMane : MonoBehaviour
{
    public GameObject scoreObj = null;
    public int scoreNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        scoreNum = scoreNum + 10;
    }
}
