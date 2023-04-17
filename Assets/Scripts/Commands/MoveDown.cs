using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : ICommand
{
    IPlayer player;

    public MoveDown(IPlayer player)
    {
        this.player = player;
    }

    public void Execute()
    {
        //player.transform.position += Vector3.back;
        player.MoveDown();
    }

    public void Undo()
    {
        //player.transform.position += Vector3.forward;
        player.MoveUp();
    }
}
