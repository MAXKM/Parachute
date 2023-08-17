using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectAnswer : MonoBehaviour
{
    public QuizScript quizScript;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (quizScript.textArray[quizScript.rand,1] == "A")
        {
            Debug.Log("ê≥â");
        }
    }
}
