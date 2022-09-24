using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Genetics
{
    public class DNA
    {
        public DNAController controller;

        public List<Gene> genes = new List<Gene>();

        int geneCount;

        // Start is called before the first frame update
        public DNA()
        {
            genes.Clear();
            foreach (GeneSO g in controller.genes)
            {
                this.genes.Add(new Gene(g.geneName, mRNA(g.number)));
            }
        }

        public float mRNA(float number)
        {
            int random = Random.Range(0, 100);
            if (random < controller.mutateRate)
            {
                number += Mathf.Round(Random.Range(-0.5f, 0.5f) * 100) / 100;
                number = Mathf.Clamp(number, 0.1f, 10);
                Debug.Log (number);
                return number;
            }
            else
            {
                Debug.Log (number);
                return number;
            }
        }
    }
}
