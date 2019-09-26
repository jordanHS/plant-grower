namespace PlantGrower.Models
{
  public class Plant
  {
    public int PlantHealth { get; set; }
    public string PlantName { get; set; }
    public Plant(int plantHealth, string plantName)
    {
      PlantHealth = plantHealth;
      PlantName = plantName;
    }

    public void Water()
    {
      PlantHealth += 2;
    }
    public void Feed()
    {
      PlantHealth += 1;
    }
    public void GiveSunshine()
    {
      PlantHealth += 3;
    }
    public void Windstorm()
    {
      PlantHealth -= 1;
    }
    public void AphidAttack()
    {
      PlantHealth -= 3;
    }
    public void SlugBite()
    {
      PlantHealth -= 2;
    }
  }
}
