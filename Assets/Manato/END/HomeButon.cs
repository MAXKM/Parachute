using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeButon : MonoBehaviour
{
    public void OnClickHomeButton()
    {
        SceneManager.LoadScene("sTitleScene2");
    }
}
