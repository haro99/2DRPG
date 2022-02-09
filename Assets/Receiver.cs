using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IReceiver
{
    // インターフェイスにどんなメソッドを定義するか・インターフェイスを分けるか等は状況に応じて
    void Receive1();
    void Receive2();
}

public interface Character
{
    void Command();
    void Damage(int point);
}

public class Receiver : IReceiver
{
    public void Receive1()
    {
        Debug.Log("Commandを受け取りました。");
    }

    public void Receive2()
    {
        Debug.Log("Commandを受け取ったよ。");
    }
}
