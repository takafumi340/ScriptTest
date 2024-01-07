using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.IsolatedStorage;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class Test : MonoBehaviour
{
    void Start()
    {
        //要素数5の配列を初期化する
        int[] array = { 5, 10, 15, 20, 25 };

        //配列の各要素の値を順番に表示する
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        //配列の各要素の値を逆順に表示する
        for (int i = array.Length - 1; 0 <= i; i--) 
        {
            Debug.Log(array[i]);
        }

        //Bossクラスの変数を宣言してインスタンスを代入する
        Boss boss = new Boss();

        //Magic関数を11回使う
        for (int i = 0; i < 11; i++)
        {
            boss.Magic();
        }

    }

    //Update is called once per frame
    private void Update()
    {
        
    }
}
public class Boss
{
    //mpを53で初期化する
    private int mp = 53;

    //魔法攻撃用の関数
    public void Magic()
    {
        if (mp >= 5)
        {
            //mpを5以上の場合は、5減らし、"魔法攻撃をした。残りMPは○○。"と表示する
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
        else
        {
            //それ以外の場合（mpが5未満の場合）は、"MPが足りないため、魔法が使えない。"と表示する
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
    }
}