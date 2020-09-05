using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageUiManager : MonoBehaviour
{
    //ステージ名
    public Text areaText;


    //エリア名を変える関数(AreaSelectManagerから呼ばれる想定）
    public void UpdateAreaText(string areaName)
    {
        areaText.text = areaName;
    }

}
