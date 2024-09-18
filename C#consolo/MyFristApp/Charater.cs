

class Character
{
    public string name;
    public int health;
    public int streath;
    public static  void player()
    {
        Character player = new Character();
        player.name = "Charles";
        player.health = 100;
        player.streath = 100;
        Console.WriteLine(player.name);

         Character player1 = new Character();
        player1.name = "Chuck";
        player1.health = 100;
        player1.streath = 100;
        Console.WriteLine(player1.name);
    }
}