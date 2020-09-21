using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageClearManager : MonoBehaviour
{
    public void ClickTransitionButton() {
        SceneManager.LoadScene("StageSelectScene");
    }

}
