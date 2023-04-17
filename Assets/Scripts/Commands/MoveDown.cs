using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : ICommand
{
    GameObject player;

    public MoveDown(GameObject player)
    {
        this.player = player;
    }

    public void Execute()
    {
        player.transform.position += Vector3.back;
    }

    public void Undo()
    {
        player.transform.position += Vector3.forward;
    }
}
