using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ListObj listObj;

    private void Update()
    {
        if (listObj.list.Count >= 3)
        {
            listObj.WinGame();
        }
    }
}
