using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    public Player player;

    List<ICommand> commands = new List<ICommand>();

    public Material black;
    public Material blue;
    public Material red;
    public Material purple;

    Material currentColor;

    void Start()
    {
        currentColor = GetComponent<Material>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            MoveDown();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            MoveUp();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            MoveLeft();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            MoveRight();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Undo();
        }
    }

    public void MoveUp()
    {
        MoveUp move = new MoveUp(player);
        commands.Add(move);
        move.Execute();
    }
    public void MoveDown()
    {
        MoveDown move = new MoveDown(player);
        commands.Add(move);
        move.Execute();
    }
    public void MoveLeft()
    {
        MoveLeft move = new MoveLeft(player);
        commands.Add(move);
        move.Execute();
    }
    public void MoveRight()
    {
        MoveRight move = new MoveRight(player);
        commands.Add(move);
        move.Execute();
    }

    public void ChangeColorToRed()
    {
        SetColorRed colorChange = new SetColorRed(player, currentColor, red);
        currentColor = red;
        commands.Add(colorChange);
        colorChange.Execute();
    }
    public void ChangeColorToBlack()
    {
        SetColorBlack colorChange = new SetColorBlack(player, currentColor, black);
        currentColor = black;
        commands.Add(colorChange);
        colorChange.Execute();
    }
    public void ChangeColorToBlue()
    {
        SetColorBlue colorChange = new SetColorBlue(player, currentColor, blue);
        currentColor = blue;
        commands.Add(colorChange);
        colorChange.Execute();
    }
    public void ChangeColorToPurple()
    {
        SetColorPurple colorChange = new SetColorPurple(player, currentColor, purple);
        currentColor = purple;
        commands.Add(colorChange);
        colorChange.Execute();
    }

    public void Undo()
    {
        if (commands.Count > 0)
        {
            commands[commands.Count - 1].Undo();
            commands.RemoveAt(commands.Count - 1);

            currentColor = player.gameObject.GetComponent<MeshRenderer>().material;
        }
    }
}
