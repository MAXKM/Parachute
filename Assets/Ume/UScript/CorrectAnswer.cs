using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectAnswer : MonoBehaviour
{
    public QuizScript quizScript;
    public ScoreMane scoreMane;
    public bool hantei;
    public AudioClip shoot;
    AudioSource audioSource;
    void Start()
    {
        hantei = false;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && quizScript.textArray[quizScript.rand,1] == "A")
        {
            hantei = true;
            scoreMane.MaruBatu(hantei);
            audioSource.PlayOneShot(shoot);
        }
    }
}
