using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GridManager", menuName = "GridManager")]
public class GridManager : ScriptableObject
{
    public int x, y;
    public void CreateGrid(GameObject gameObject, Transform parent)
    {
        for (int i = 0; i < y; i++)
        {
            for (int j = 0; j < x; j++)
            {
                Instantiate(gameObject, new Vector2(j, i), Quaternion.identity, parent);
            }
        }
    }
}
