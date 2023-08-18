using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExplanationButton : MonoBehaviour
{
    public void OnClickExplanationButton()
    {
        SceneManager.LoadScene("Explanation");
    }
}
