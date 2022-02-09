using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Command
{
    void Execute();
}

public class ConcreteCommand1 : Command
{
    private IReceiver _receiver;

    public ConcreteCommand1(IReceiver receiver)
    {
        _receiver = receiver;
    }

    public void Execute()
    {
        // 実装の中身についてはReceiverに委譲している
        // この箇所に細かい処理の流れを書く場合もある
        _receiver.Receive1();
    }
}

public class ConcreteCommand2 : Command
{
    private IReceiver _receiver;

    public ConcreteCommand2(IReceiver receiver)
        => _receiver = receiver;

    public void Execute()
        => _receiver.Receive2();
}