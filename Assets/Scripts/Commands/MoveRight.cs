using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : ICommand
{
    GameObject player;

    public MoveRight(GameObject player)
    {
        this.player = player;
    }

    public void Execute()
    {
        player.transform.position += Vector3.right;
    }

    public void Undo()
    {
        player.transform.position += Vector3.left;
    }
}
