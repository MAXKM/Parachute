using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreMane : MonoBehaviour
{
    [SerializeField]TextMeshProUGUI scoreObj;
    public static int scoreNum = 0;

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
            Debug.Log("no");
            PlayerPrefs.SetInt("fscore", scoreNum);
            PlayerPrefs.Save();
            SceneManager.LoadScene("sResultScene");
        }
    }
}
