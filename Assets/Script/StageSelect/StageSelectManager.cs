using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSelectManager : MonoBehaviour
{
    //ボタンが押されたら効果音を出す
    public void OnToSelectButton()
    {
        SoundManager.sound.PlaySe(0);
        Debug.Log("音が鳴った");
    }

}
