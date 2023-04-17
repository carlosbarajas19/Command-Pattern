using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : ICommand
{
    IPlayer player;

    public MoveLeft(IPlayer player)
    {
        this.player = player;
    }

    public void Execute()
    {
        player.MoveLeft();
    }

    public void Undo()
    {
        player.MoveRight();
    }
}
