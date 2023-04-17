using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : ICommand
{
    GameObject player;

    public MoveLeft(GameObject player)
    {
        this.player = player;
    }

    public void Execute()
    {
        player.transform.position += Vector3.left;
    }

    public void Undo()
    {
        player.transform.position += Vector3.right;
    }
}
