using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResultMane : MonoBehaviour
{
    //[SerializeField] ScoreMane scoremane;
    [SerializeField] TextMeshProUGUI HighScoreObj;
    public int HighScore = 0;
    public int Fscore = 0;
    // Start is called before the first frame update
    void Start()
    {
        HighScore = PlayerPrefs.GetInt("Highscore", 0);
        Fscore = PlayerPrefs.GetInt("fscore", 0);
        if (HighScore < Fscore)
        {
            HighScore = Fscore;
        }
        HighScoreObj.text = "HighScore:" + HighScore + "\nYourScore" + Fscore;
        PlayerPrefs.SetInt("Highscore", HighScore);
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
    
}
