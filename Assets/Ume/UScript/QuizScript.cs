using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class QuizScript : MonoBehaviour
{
    public string[,] textArray;
    public Text quizText;
    public int rand;
    public GameObject player;
    void Start()
    {
        textArray = new string[,]
        {
        {"サッカーの和名は蹴球である", "A"},
        {"プロの試合は前半・後半を合わせて\n120分のゲームである", "B"},
        {"審判が途中で中断した時間を最後に延長する\n時間のことロスタイムという", "B"},
        {"サッカーの主な4つのポジションの一つで\n前線で攻撃を行う選手のことをフォワードという","A"},
        {"サッカーの主な4つのポジションの一つで\n後方で守備を行う選手のことをミッドフィルダーという","B"}
        };//Aが正解Bが不正解
        rand = Random.Range(0, 4);

    }
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            quizText.text = textArray[rand, 0];
        }
    }
}
