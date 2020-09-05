using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//BGM、SEを管理するクラス
public class SoundManager : MonoBehaviour
{
    //このクラスを外部から参照できるようにする
    public static SoundManager sound;

    //全てのStart関数が呼ばれる前に処理を行う
    private void Awake()
    {
        if (sound == null)
        {
            //soundに自身を代入する
            sound = this;
            //シーンが移動してもSoundManagerを破壊しない
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            //同じものがあったら破壊する
            Destroy(this.gameObject);
        }
    }

    //BGMの音源
    public AudioClip[] bgmClip;

    //SEの音源
    public AudioClip[] seClip;

    //SEを再生するプレイヤー
    public AudioSource seAudio;
 
    //BGMを再生するプレイヤー 
    public AudioSource bgmAudio;



    //SEを一度だけ鳴らす
    public void PlaySe(int index)
    {
        //渡されてきた引数を添え字にして音源を再生する
        seAudio.PlayOneShot(seClip[index]);
    }


    //曲を再生する
    public void PlayBgm(string sceneName)
    {
        //曲を止める
        bgmAudio.Stop();

        //曲を選ぶ。送られてきた引数でどのシーンかを判断し、音源を設定する。
        switch (sceneName)
        {
            case "TitleScene":
                bgmAudio.clip = bgmClip[0];
                break;

            case "AreaSelectScene":
                bgmAudio.clip = bgmClip[1];
                break;

            case "StageSelectScene":
                bgmAudio.clip = bgmClip[2];
                break;

            case "GameScene":
                bgmAudio.clip = bgmClip[3];
                break;

        }
        //曲を再生する
        bgmAudio.Play();
    }

}

