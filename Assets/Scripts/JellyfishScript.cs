using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyfishScript : MonoBehaviour
{
    public GameObject jellyfish;
    public float xCoordinate;
    public float yCoordinate;
    public Vector3 sizeChange;

    public void MoveLeft()
    {
        xCoordinate = xCoordinate - 0.1f;
        jellyfish.transform.position = new Vector3(xCoordinate, yCoordinate, 0);
    }

    public void MoveRight()
    {
        xCoordinate = xCoordinate + 0.1f;
        jellyfish.transform.position = new Vector3(xCoordinate, yCoordinate, 0);
    }

    public void MoveUp()
    {
        yCoordinate = yCoordinate + 0.1f;
        jellyfish.transform.position = new Vector3(xCoordinate, yCoordinate, 0);
    }

    public void MoveDown()
    {
        yCoordinate = yCoordinate - 0.1f;
        jellyfish.transform.position = new Vector3(xCoordinate, yCoordinate, 0);
    }

    public void RotateLeft()
    {
        jellyfish.transform.Rotate(20f, 0f, 0f);
    }

    public void Grow()
    {
        jellyfish.transform.localScale = jellyfish.transform.localScale + sizeChange;
    }

    public void Shrink()
    {
        jellyfish.transform.localScale = jellyfish.transform.localScale - sizeChange;
    }

    public void ResetJellyfish()
    {
        xCoordinate = 1;
        yCoordinate = 1.5f;
        jellyfish.transform.position = new Vector3(xCoordinate, yCoordinate, 0);
        jellyfish.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        jellyfish.transform.localScale = new Vector3(1, 1, 1);
    }
}
    