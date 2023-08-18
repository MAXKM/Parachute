using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectAnswer : MonoBehaviour
{
    public QuizScript quizScript;
    public ScoreMane scoreMane;
    public bool hantei;
    void Start()
    {
        hantei = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && quizScript.textArray[quizScript.rand,1] == "A")
        {
            Debug.Log("ê≥â");
            hantei = true;
            scoreMane.MaruBatu(hantei);
        }
    }
}
