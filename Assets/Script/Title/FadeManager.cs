using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FadeManager : MonoBehaviour
{

    //アルファ値を設定するためにキャンバスグループをアタッチする
    public CanvasGroup canvasGroup;

    //シングルトンの作成　シーンが切り替わっても破壊されないようにする
    public static FadeManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            //同じものがあったら破壊する
            Destroy(gameObject);
        }
    }

    public void Start()
    {
        //最初にボタンを押せるように初期化する
        canvasGroup.blocksRaycasts = false;
    }




    public void FadeOut()
    {
        //ボタンを押せないようにする
        canvasGroup.blocksRaycasts = true;

        //画面を2秒かけて黒くする
        canvasGroup.DOFade(1, 2f)
            .OnComplete(() => canvasGroup.blocksRaycasts = false);
    }

    public void FadeIn()
    {
        //ボタンを押せないようにする
        canvasGroup.blocksRaycasts = false;

        //画面を元に戻す
        canvasGroup.DOFade(0, 1f)
            .OnComplete(() => canvasGroup.blocksRaycasts = false);
    }

    //画面を黒くし、元に戻す
    public void FadeOutToIn(TweenCallback action)
    {
        //ボタンを押せないようにする
        canvasGroup.blocksRaycasts = true;

        //画面を黒くした後に、action（シーンのロード）を行い、画面を明るくする
        canvasGroup.DOFade(1, 0.8f).OnComplete(
            () =>{
                action();
                FadeIn();
            }
            );
    }
}
