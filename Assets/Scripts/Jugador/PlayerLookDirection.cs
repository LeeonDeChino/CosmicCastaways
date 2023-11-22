using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLookDirection : MonoBehaviour
{
    public bool isLookingRight = true;

    public void LookDirection(int val)
    {
        if (val == -1)
        {
            isLookingRight = false;
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            isLookingRight = true;
            transform.localScale = new Vector3(1, 1, 1);
        }
    }

}
