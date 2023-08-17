using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayScript : MonoBehaviour
{
    [SerializeField] private GameObject quiz;
    bool Dquiz;
    [SerializeField] private GameObject quizTitle;
    [SerializeField] private GameObject quizText;
    bool DquizTT;
    void Start()
    {
        Dquiz = false;
        DquizTT = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.y <= 200 && Dquiz == false)
        {
            quiz.SetActive(true);
            Dquiz = true;
        }
        if (this.transform.position.y <= 125 && DquizTT == true)
        {
            quizTitle.SetActive(false);
            quizText.SetActive(false);
            DquizTT = false;
        }
    }
}
