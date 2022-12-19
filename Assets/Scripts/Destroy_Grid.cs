using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Grid : MonoBehaviour
{
    [SerializeField] public string destroyTag;

    private void Awake()
    {
        if (this.destroyTag == "")
        {
           this.destroyTag = "Grid";
        }

        Destroy(GameObject.FindWithTag("Grid"));

    }
}
