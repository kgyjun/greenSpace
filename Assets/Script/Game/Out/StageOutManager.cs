using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageOutManager : MonoBehaviour
{
    public void ClickTransitionButton() {
        SceneManager.LoadScene("StageSelectScene");
    }

}
