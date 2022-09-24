using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{
    public int width;

    public int height;

    public List<Wheat> corns;

    // Start is called before the first frame update
    void Start()
    {
        corns = new List<Wheat>();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
