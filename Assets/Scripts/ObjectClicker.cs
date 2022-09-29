using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClicker : MonoBehaviour
{
    public ListObj listObj;

    private void OnMouseDown()
    {
        listObj.list.Add(this.transform.position);
        listObj.list2.Add(this.gameObject);
        GetComponent<BoxCollider2D>().enabled = false;
        transform.GetChild(0).gameObject.SetActive(true);
    }
}
