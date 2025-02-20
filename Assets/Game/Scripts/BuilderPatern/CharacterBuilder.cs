public static class A
{
    public static CharacterBuilder Character => new CharacterBuilder();
}

public class CharacterBuilder
{
    private Character character = new Character();

    public CharacterBuilder WithName(string name)
    {
        character.name = name;

        return this;
    }

    public CharacterBuilder WithHealth(int health)
    {
        character.health = health;

        return this;
    }

    public CharacterBuilder WithStrength(int strength)
    {
        character.strength = strength;

        return this;
    }

    public CharacterBuilder WithIntelligence(int intelligence)
    {
        character.intelligence = intelligence;

        return this;
    }

    public CharacterBuilder WithWeapon(Weapon weapon)
    {
        character.weapon = weapon;

        return this;
    }

    public CharacterBuilder WithBuff(Buff buff)
    {
        character.buff = buff;

        return this;
    }

    public Character Build()
    {
        return character;
    }

    public static implicit operator Character(CharacterBuilder builder)
    {
        return builder.Build();
    }
}
