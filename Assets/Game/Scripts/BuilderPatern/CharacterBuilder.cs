public static class A
{
    public static CharacterBuilder Character => new CharacterBuilder();
}

public class CharacterBuilder
{
    private string name;
    private int health;
    private int strength;
    private int intelligence;
    private Weapon weapon;
    private Buff buff;

    public CharacterBuilder WithName(string name)
    {
        this.name = name;

        return this;
    }

    public CharacterBuilder WithHealth(int health)
    {
        this.health = health;

        return this;
    }

    public CharacterBuilder WithStrength(int strength)
    {
        this.strength = strength;

        return this;
    }

    public CharacterBuilder WithIntelligence(int intelligence)
    {
        this.intelligence = intelligence;

        return this;
    }

    public CharacterBuilder WithWeapon(Weapon weapon)
    {
        this.weapon = weapon;

        return this;
    }

    public CharacterBuilder WithBuff(Buff buff)
    {
        this.buff = buff;

        return this;
    }

    public Character Build()
    {
        Character character = new Character();
        character.name = name;
        character.health = health;
        character.strength = strength;
        character.intelligence = intelligence;
        character.weapon = weapon;
        character.buff = buff;

        return character;
    }

    public static implicit operator Character(CharacterBuilder builder)
    {
        return builder.Build();
    }
}
