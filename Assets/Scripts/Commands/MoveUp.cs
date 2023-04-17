using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : ICommand
{
    IPlayer player;

    public MoveUp(IPlayer player)
    {
        this.player = player;
    }

    public void Execute()
    {
        player.MoveUp();
    }

    public void Undo()
    {
        player.MoveDown();
    }
}
