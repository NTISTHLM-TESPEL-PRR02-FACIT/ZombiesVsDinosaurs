class Dinosaur : Creature
{
  public Dinosaur()
  {
    intelligence = Random.Shared.Next(5, 15);
    toughness = Random.Shared.Next(5, 15);
    strength = Random.Shared.Next(5, 15);

    Console.WriteLine("Created dinosaur with intelligence " + intelligence + ", toughness " + toughness + " and strength " + strength);
  }
}