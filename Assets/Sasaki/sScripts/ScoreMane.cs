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
    public GameObject boom;
    public GameObject Player;
    GameObject b1;
    public Rigidbody rb;

    //public GameObject fade;//�C���X�y�N�^����Prefab������Canvas������
    //private bool a;

    // Start is called before the first frame update
    void Start()
    {
        scoreNum = 0;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 posi = this.transform.position;
        // �e�L�X�g�̕\�������ւ���
        scoreObj.text = "Score:" + scoreNum + "\nHeight:" + posi.y.ToString("F0");
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
            b1 = Instantiate(boom, new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z), Quaternion.Euler(0, 0, 0));
            Player.SetActive(false);
            rb.constraints = RigidbodyConstraints.FreezePosition;
            Invoke(nameof(SeceneMove), 2.0f);
        }

        //if (other.CompareTag("Goal"))
        //{
        //    Debug.Log("last");
        //    OverObj.text = "GameClear!";
        //    PlayerPrefs.SetInt("fscore", scoreNum);
        //    PlayerPrefs.Save();
        //    SceneManager.LoadScene("sResultScene");
        //}
    }
}
