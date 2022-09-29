using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridCreator : MonoBehaviour
{
    public GridManager gridManager;
    public GameObject gridObj;

    private void Start()
    {
        gridManager.CreateGrid(gridObj, this.transform);
        Camera.main.transform.position = new Vector3((float)(gridManager.x - 1) / 2, (float)(gridManager.y - 1) / 2, -gridManager.y);
    }
}
