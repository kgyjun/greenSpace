using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleManager : MonoBehaviour
{
   
    void Start()
    {
        //タイトルの曲を流す
        SoundManager.sound.PlayBgm("TitleScene");
    }

    //ボタンが押されたら効果音を出す
    public void OnToTitleButton()
    {
        SoundManager.sound.PlaySe(0);

        Debug.Log("音が鳴った");
    }



}
