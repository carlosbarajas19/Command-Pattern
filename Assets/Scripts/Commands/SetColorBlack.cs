using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColorBlack : ICommand
{
    GameObject player;
    Material previousMaterial;
    Material newMaterial;

    public SetColorBlack(GameObject player, Material previousMaterial, Material newMaterial)
    {
        this.player = player;
        this.previousMaterial = previousMaterial;
        this.newMaterial = newMaterial;
    }

    public void Execute()
    {
        player.GetComponent<MeshRenderer>().material = newMaterial;
    }

    public void Undo()
    {
        player.GetComponent<MeshRenderer>().material = previousMaterial;
    }
}
