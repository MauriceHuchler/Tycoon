using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheat : MonoBehaviour
{
    public float currentReproductionNumber;

    public float repoductionTime;

    public Genetics.DNA dnaWheat;

    public Gene wachstum;

    // Start is called before the first frame update
    void Start()
    {
        this.wachstum =
            dnaWheat.genes.Find(gen => gen.name.Equals("WachstumsRate"));
        this.currentReproductionNumber = 0;
    }

    // Update is called once per frame
    void Update()
    {
        this.currentReproductionNumber += wachstum.number * Time.deltaTime;
        if (currentReproductionNumber > repoductionTime)
        {
            reproduce();
        }
    }

    void reproduce()
    {
        currentReproductionNumber = 0;
        Object.Instantiate(this, this.transform.position, Quaternion.identity);
    }
}
