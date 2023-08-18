using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class QuizScript : MonoBehaviour
{
    public string[,] textArray;
    public Text quizText;
    public Text quizTitle;
    public int rand;
    public GameObject player;
    void Start()
    {
        textArray = new string[,]
        {
        {"�T�b�J�[�̘a���͏R���ł���", "A"},
        {"�v���̎����͑O���E�㔼�����킹��\n120���̃Q�[���ł���", "B"},
        {"�R�����r���Œ��f�������Ԃ��Ō�ɉ�������\n���Ԃ̂��ƃ��X�^�C���Ƃ���", "B"},
        {"�T�b�J�[�̎��4�̃|�W�V������\n��őO���ōU�����s���I��̂��Ƃ�\n�t�H���[�h�Ƃ���","A"},
        {"�T�b�J�[�̎��4�̃|�W�V������\n��Ō���Ŏ�����s���I��̂��Ƃ�\n�~�b�h�t�B���_�[�Ƃ���","B"}
        };//A������B���s����
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
            quizTitle.text = "���";
        }
    }
}
