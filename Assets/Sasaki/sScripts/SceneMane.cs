using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMane : MonoBehaviour
{
    //�^�C�g����ʂ���Q�[����ʂ�
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("Sasaki01");
    }

    //���U���g��ʂ���^�C�g����ʂ�
    public void OnClickTitleButton()
    {
        SceneManager.LoadScene("sTitleScene");
    }

    //���U���g��ʂ���Q�[����ʂ�
    public void OnClickRetryButton()
    {
        SceneManager.LoadScene("Sasaki01");
    }


}
