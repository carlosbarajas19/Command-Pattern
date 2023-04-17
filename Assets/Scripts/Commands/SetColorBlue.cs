using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColorBlue : ICommand
{
    IPlayer player;
    Material previousMaterial;
    Material newMaterial;

    public SetColorBlue(IPlayer player, Material previousMaterial, Material newMaterial)
    {
        this.player = player;
        this.previousMaterial = previousMaterial;
        this.newMaterial = newMaterial;
    }

    public void Execute()
    {
        player.ChangeColor(newMaterial);
    }

    public void Undo()
    {
        player.ChangeColor(previousMaterial);
    }
}
