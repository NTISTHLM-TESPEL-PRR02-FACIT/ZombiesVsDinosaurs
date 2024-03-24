
List<Dinosaur> dinosaurs = new List<Dinosaur>();
List<Zombie> zombies = new List<Zombie>();

int num = -1;
bool success = false;
while (success == false)
{
  Console.Write("Please type in the number of zombies and dinosaurs to create for each team: ");
  string inputNum = Console.ReadLine();

  success = int.TryParse(inputNum, out num);

  if (success && num < 1)
  {
    success = false;
  }
}

for (int i = 0; i < num; i++)
{
  Dinosaur dino = new Dinosaur();
  Zombie zombie = new Zombie();
  dinosaurs.Add(dino);
  zombies.Add(zombie);
}

Console.WriteLine("Created " + dinosaurs.Count() + " dinosaurs.");
Console.WriteLine("Created " + zombies.Count() + " zombies.");

Console.ReadLine();