using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AreaSceneTransition : MonoBehaviour
{
    //ステージセレクトにセットするエリアの名前
    private string areaName;

    //ステージセレクトにセットするエリアの名前のgatter、setter
    public string GetAreaName()
    {
        return this.areaName;
    }

    public void SetAreaName(string areaName)
    {
        this.areaName = areaName;
    }



    //エリアセレクトからステージセレクトへ遷移する時に使うシーンのロード
    public void AreaSelect_SceneLoad(string areaName)
    {
        //ステージセレクトにセットするエリアの名前を設定する
        SetAreaName(areaName);

        //ロード時にイベントを使用する。右辺の関数がロード時に実行される
        SceneManager.sceneLoaded += AreaSelect_SceneLoad_Event;

        //ステージセレクトシーンをロードする
        SceneManager.LoadScene("StageSelectScene");
    }

    //エリアセレクトからステージセレクトに遷移する時に呼ばるシーンのロード
    private void AreaSelect_SceneLoad_Event(Scene next, LoadSceneMode mode)
    {
        //AreaTextオブジェクトを探し出し、代入する
        GameObject stageSelectAreaText = GameObject.Find("AreaText");
        Text text = stageSelectAreaText.GetComponent<Text>();

        //ステージセレクトにセットするエリアの名前を取得する
        string areaName = GetAreaName();

        //エリア名をステージセレクトにセット
        text.text = areaName;

        //シーンのロード後に、イベントを削除する
        SceneManager.sceneLoaded -= AreaSelect_SceneLoad_Event;
    }
}
