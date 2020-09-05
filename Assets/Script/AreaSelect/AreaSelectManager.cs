using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaSelectManager : MonoBehaviour
{
    
    public StageUiManager stageUiManager;

    //ボタンが押されたら効果音を出す
    public void OnToAreaButtonSe()
    {
        SoundManager.sound.PlaySe(0);
    }

    //ステージセレクトのエリア名を更新する
    public void UpdateStageText(string stageName)
    {
        stageUiManager.UpdateAreaText(stageName);
    }

}
