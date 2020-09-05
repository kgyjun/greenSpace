using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTransitionManager : MonoBehaviour
{

    //シーンの移動
    public void Load(string sceneName)
    {
        //次のシーンの曲を再生する
        SoundManager.sound.PlayBgm(sceneName);
        //シーンをロードする
        SceneManager.LoadScene(sceneName);
    }

}
