using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreMane : MonoBehaviour
{
    [SerializeField]TextMeshProUGUI scoreObj;
    public static int scoreNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        //scoreNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // テキストの表示を入れ替える
        scoreObj.text ="Score:"+ scoreNum;
    }

    private void OnTriggerEnter(Collider other)
    {
        scoreNum = scoreNum + 10;
        Debug.Log("yes");
    }
}
