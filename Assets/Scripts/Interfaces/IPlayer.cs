using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayer 
{

    public void MoveUp();
    public void MoveDown();
    public void MoveLeft();
    public void MoveRight();

    public void ChangeColor(Material color);
}
