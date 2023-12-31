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
    public GameObject boom;
    public GameObject Player;
    GameObject b1;
    public Rigidbody rb;
    public PlayerController playerController;
    public AudioClip exciting;
    public AudioClip GRing;
    public AudioClip BRing;
    public AudioClip NRing;
    AudioSource audioSource;
    //public GameObject fade;//インスペクタからPrefab化したCanvasを入れる
    //private bool a;

    // Start is called before the first frame update
    void Start()
    {
        scoreNum = 0;
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        Vector3 posi = this.transform.position;
        // テキストの表示を入れ替える
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
        SceneManager.LoadScene("sResultScene2");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Add"))
        {
            audioSource.PlayOneShot(GRing);
            scoreNum = scoreNum + 10;
            //Debug.Log("+");
        }

        if (other.CompareTag("Decrease"))
        {
            audioSource.PlayOneShot(BRing);
            scoreNum = scoreNum - 10;
            //Debug.Log("-");
        }

        if (other.CompareTag("GOver"))
        {
            //a = false;
            //Debug.Log("no");
            audioSource.PlayOneShot(NRing);
            Player.SetActive(false);
            playerController.play = false;
            rb.constraints = RigidbodyConstraints.FreezePosition;
            b1 = Instantiate(boom, new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z), Quaternion.Euler(0, 0, 0));
            Invoke(nameof(SeceneMove), 2.0f);
        }

        if (other.CompareTag("Goal"))
        {
            //Debug.Log("last");
            scoreNum = scoreNum + 1000;
            audioSource.PlayOneShot(exciting);
            Invoke(nameof(SeceneMove), 2.0f);
        }
    }
}
