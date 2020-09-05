using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSceneTransition : MonoBehaviour
{
    //フェードインの後、シーンのロードをする
    public void Load(string sceneName)
    {
        FadeManager.instance.FadeOutToIn( () => LoadToScene(sceneName));
    }
    public void LoadToScene(string sceneName)
    {
        //次のシーンの曲を再生する
        SoundManager.sound.PlayBgm(sceneName);
        //シーンをロードする
        SceneManager.LoadScene(sceneName);
    }
}
