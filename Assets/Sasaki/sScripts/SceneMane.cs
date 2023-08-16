using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMane : MonoBehaviour
{
    //タイトル画面からゲーム画面へ
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("Sasaki01");
    }

    //リザルト画面からタイトル画面へ
    public void OnClickTitleButton()
    {
        SceneManager.LoadScene("sTitleScene");
    }

    //リザルト画面からゲーム画面へ
    public void OnClickRetryButton()
    {
        SceneManager.LoadScene("Sasaki01");
    }


}
