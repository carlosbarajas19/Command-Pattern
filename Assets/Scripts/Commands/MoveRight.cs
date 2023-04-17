using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : ICommand
{
    IPlayer player;

    public MoveRight(IPlayer player)
    {
        this.player = player;
    }

    public void Execute()
    {
        player.MoveRight();
    }

    public void Undo()
    {
        player.MoveLeft();
    }
}
