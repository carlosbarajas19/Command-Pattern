using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : ICommand
{
    GameObject player;

    public MoveUp(GameObject player)
    {
        this.player = player;
    }

    public void Execute()
    {
        player.transform.position += Vector3.forward;
    }

    public void Undo()
    {
        player.transform.position += Vector3.back;
    }
}
