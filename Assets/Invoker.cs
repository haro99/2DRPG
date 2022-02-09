using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoker
{
    private Queue<Command> _commands = new Queue<Command>();

    public void AddCommand(Command command)
        => _commands.Enqueue(command);

    public void Execute()
    {
        while (_commands.Count != 0)
        {
            var command = _commands.Dequeue();
            command.Execute();
        }
    }
}
