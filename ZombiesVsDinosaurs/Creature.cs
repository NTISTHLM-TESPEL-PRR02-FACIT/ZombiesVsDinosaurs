class Creature
{
  protected int intelligence = 0;
  protected int toughness = 0;
  protected int strength = 0;

  public int PlayChess()
  {
    int result = Random.Shared.Next(0, 10) + intelligence;

    if (result > 20)
    {
      return 20;
    }
    else
    {
      return result;
    }
  }

  public int Wrestle()
  {
    int result = Random.Shared.Next(0, 10) + toughness + strength;

    if (result > 20)
    {
      return 20;
    }
    else
    {
      return result;
    }
  }

  public int ArmWrestle()
  {
    int result = Random.Shared.Next(0, 10) + strength;

    if (result > 20)
    {
      return 20;
    }
    else
    {
      return result;
    }
  }

}