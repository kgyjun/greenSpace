using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageClearJudge : MonoBehaviour
{
    //ボタン
    public Button button;

    //クリアしているかの判定　データをロードするという処理が必要？
    private bool crea;

    //クリアしていないものは色を塗りつぶす　まだデータの概念がないのでコメントアウト
    //public void Start()
    //{
    //    crea = false;
    //    if (!crea)
    //    {
    //        //クリアフラッグがfalseだったら色をかえる
    //        button.GetComponentInChildren<Image>().color = new Color(231.0f / 255.0f, 20.0f / 255.0f, 20.0f / 255.0f, 255.0f / 255.0f);
    //    }
    //}

}
