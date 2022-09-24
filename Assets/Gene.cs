[System.Serializable]
public class Gene
{
    public float number;

    public string name;

    public Gene(string name, float number)
    {
        this.name = name;
        this.number = number;
    }

    public Gene reproduceGene(Gene b)
    {
        float newNumber = (this.number + b.number) / 2;
        return new Gene(this.name, newNumber);
    }
}
