using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreMane : MonoBehaviour
{
    [SerializeField]TextMeshProUGUI scoreObj;
    [SerializeField] TextMeshProUGUI OverObj;
    public static int scoreNum = 0;
    //private bool a;

    // Start is called before the first frame update
    void Start()
    {
        scoreNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // テキストの表示を入れ替える
        scoreObj.text ="Score:"+ scoreNum;
    }

    public void MaruBatu(bool hantei)
    {
        if (hantei == true)
        {
            scoreNum = scoreNum + 100;
        }
        else
        {
            scoreNum = scoreNum - 100;
        }
    }
    private void SeceneMove()
    {
        PlayerPrefs.SetInt("fscore", scoreNum);
        PlayerPrefs.Save();
        SceneManager.LoadScene("sResultScene");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Add"))
        {
            scoreNum = scoreNum + 10;
            Debug.Log("+");
        }

        if (other.CompareTag("Decrease"))
        {
            scoreNum = scoreNum - 10;
            Debug.Log("-");
        }

        if (other.CompareTag("GOver"))
        {
            //a = false;
            Debug.Log("no");
            OverObj.text = "GameOver";
            Invoke(nameof(SeceneMove), 3.5f);
        }

        //if (other.CompareTag("Goal"))
        //{
        //    Debug.Log("last");
        //    PlayerPrefs.SetInt("fscore", scoreNum);
        //    PlayerPrefs.Save();
        //    SceneManager.LoadScene("sResultScene");
        //}
    }
}
