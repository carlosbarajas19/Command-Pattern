using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IPlayer
{
    

    void Start()
    {

    }

    public void ChangeColor(Material color)
    {
        gameObject.GetComponent<MeshRenderer>().material = color;
    }


    public void MoveDown()
    {
        gameObject.transform.position += Vector3.back;
    }

    public void MoveLeft()
    {
        gameObject.transform.position += Vector3.left;
    }

    public void MoveRight()
    {
        gameObject.transform.position += Vector3.right;
    }

    public void MoveUp()
    {
        gameObject.transform.position += Vector3.forward;
    }

}
