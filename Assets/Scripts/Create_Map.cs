using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create_Map : MonoBehaviour
{
    public GameObject z1;
    public GameObject z2;
    public GameObject z3;
    public GameObject z4;
    public GameObject z5;
    public GameObject z6;
    public GameObject z7;
    public GameObject z8;
    public GameObject z9;
    public GameObject z10;
    public bool first = true;
    void Start()
    {
        int exit = 0;
        Generate(z1, exit);
    }

    public void Generate(GameObject q, int ex)
    {
        GameObject cell;
        float x = q.transform.localPosition.x;
        float y = q.transform.localPosition.y;
        int rand = Random.Range(2, 11);
        if (rand == 2 && ex <= 4)
        {
            cell = Instantiate(z2, q.transform);
            if (first)
            {
                cell.transform.localPosition = new Vector3(x + 14, y, 0);
                first = false;
            }
            else
            {
                cell.transform.localPosition = new Vector3(x, y, 0);
            }
            ex++;
            Generate(cell, ex);
        }
        else if (rand == 3 && ex <= 4)
        {
            cell = Instantiate(z3, q.transform);
            if (first)
            {
                cell.transform.localPosition = new Vector3(x + 14, y, 0);
                first = false;
            }
            else
            {
                cell.transform.localPosition = new Vector3(x, y, 0);
            }
            ex++;
            Generate(cell, ex);
        }
        else if (rand == 4 && ex <= 4)
        {
            cell = Instantiate(z4, q.transform);
            if (first)
            {
                cell.transform.localPosition = new Vector3(x + 14, y, 0);
                first = false;
            }
            else
            {
                cell.transform.localPosition = new Vector3(x, y, 0);
            }
            ex++;
            Generate(cell, ex);
        }
        else if (rand == 5 && ex <= 4)
        {
            cell = Instantiate(z5, q.transform);
            if (first)
            {
                cell.transform.localPosition = new Vector3(x + 14, y, 0);
                first = false;
            }
            else
            {
                cell.transform.localPosition = new Vector3(x, y, 0);
            }
            ex++;
            Generate(cell, ex);
        }
        else if (rand == 6 && ex <= 4)
        {
            cell = Instantiate(z6, q.transform);
            if (first)
            {
                cell.transform.localPosition = new Vector3(x + 14, y, 0);
                first = false;
            }
            else
            {
                cell.transform.localPosition = new Vector3(x, y, 0);
            }
            ex++;
            Generate(cell, ex);
        }
        else if (rand == 7 && ex <= 4)
        {
            cell = Instantiate(z7, q.transform);
            if (first)
            {
                cell.transform.localPosition = new Vector3(x + 14, y, 0);
                first = false;
            }
            else
            {
                cell.transform.localPosition = new Vector3(x, y, 0);
            }
            ex++;
            Generate(cell, ex);
        }
        else if (rand == 8 && ex <= 4)
        {
            cell = Instantiate(z8, q.transform);
            if (first)
            {
                cell.transform.localPosition = new Vector3(x + 14, y, 0);
                first = false;
            }
            else
            {
                cell.transform.localPosition = new Vector3(x, y, 0);
            }
            ex++;
            Generate(cell, ex);
        }
        else if (rand == 9 && ex <= 4)
        {
            cell = Instantiate(z9, q.transform);
            if (first)
            {
                cell.transform.localPosition = new Vector3(x + 14, y, 0);
                first = false;
            }
            else
            {
                cell.transform.localPosition = new Vector3(x, y, 0);
            }
            ex++;
            Generate(cell, ex);
        }
        else if (rand == 10 && ex <= 4)
        {
            cell = Instantiate(z10, q.transform);
            if (first)
            {
                cell.transform.localPosition = new Vector3(x + 14, y, 0);
                first = false;
            }
            else
            {
                cell.transform.localPosition = new Vector3(x, y, 0);
            }
            ex++;
            Generate(cell, ex);
        }
    }
}
