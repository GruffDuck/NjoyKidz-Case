using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New List", menuName = "List")]
public class ListObj : ScriptableObject
{
    public List<Vector2> list;
    public List<GameObject> list2;
    [SerializeField] public GridManager grid;
    private void OnDisable()
    {
        list.Clear();
        list2.Clear();
    }
    public void WinGame()
    {
        if (list[0].y == list[1].y && list[1].y == list[2].y)
        {
            if (list[0].x == list[1].x - 1 && list[0].x == list[2].x - 2)
            {
                for (int i = 0; i < list2.Count; i++)
                {
                    list2[i].SetActive(false);

                }
                list.Clear();
                list2.Clear();
            }
            else if (list[0].x == list[1].x - 1 && list[0].x == list[2].x + 1)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    list2[i].SetActive(false);

                }
                list.Clear();
                list2.Clear();
            }
            else if (list[0].x == list[1].x + 1 && list[0].x == list[2].x - 1)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    list2[i].SetActive(false);

                }
                list.Clear();
                list2.Clear();
            }
            else if (list[0].x == list[1].x + 1 && list[0].x == list[2].x + 2)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    list2[i].SetActive(false);

                }
                list.Clear();
                list2.Clear();
            }

        }
        else if (list[0].x == list[1].x && list[1].x == list[2].x)
        {
            if (list[0].y == list[1].y - 1 && list[0].y == list[2].y - 2)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    list2[i].SetActive(false);

                }
                list.Clear();
                list2.Clear();
            }
            else if (list[0].y == list[1].y - 1 && list[0].y == list[2].y + 1)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    list2[i].SetActive(false);

                }
                list.Clear();
                list2.Clear();
            }
            else if (list[0].y == list[1].y + 1 && list[0].y == list[2].y - 1)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    list2[i].SetActive(false);

                }
                list.Clear();
                list2.Clear();
            }
            else if (list[0].y == list[1].y + 1 && list[0].y == list[2].y + 2)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    list2[i].SetActive(false);

                }
                list.Clear();
                list2.Clear();
            }

        }
        else if ((list[0] == (list[1] + new Vector2(-1, 1))) && (list[0] == (list[2] + new Vector2(-2, 2))))
        {
            for (int i = 0; i < list.Count; i++)
            {
                list2[i].SetActive(false);

            }
            list.Clear();
            list2.Clear();
        }
        else if ((list[0] == (list[1] + new Vector2(1, 1))) && (list[0] == (list[2] + new Vector2(2, 2))))
        {
            for (int i = 0; i < list.Count; i++)
            {
                list2[i].SetActive(false);

            }
            list.Clear();
            list2.Clear();
        }
        else if ((list[0] == (list[1] + new Vector2(-1, -1))) && (list[0] == (list[2] + new Vector2(-2, -2))))
        {
            for (int i = 0; i < list.Count; i++)
            {
                list2[i].SetActive(false);

            }
            list.Clear();
            list2.Clear();
        }
        else if ((list[0] == (list[1] + new Vector2(1, 1))) && (list[0] == (list[2] - new Vector2(-1, 1))))
        {
            for (int i = 0; i < list.Count; i++)
            {
                list2[i].SetActive(false);

            }
            list.Clear();
            list2.Clear();
        }
        else if ((list[0] == (list[1] + new Vector2(-1, 1))) && (list[0] == (list[2] - new Vector2(1, 1))))
        {
            for (int i = 0; i < list.Count; i++)
            {
                list2[i].SetActive(false);

            }
            list.Clear();
            list2.Clear();
        }
    }
}
