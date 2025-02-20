using NUnit.Framework;

public class DirectionTests
{
    [Test]
    public void Should_add_character_with_name_when_character_build()
    {
        // Arrange
        Character character = new Character();

        // Act
        character = A.Character.WithName("Paul");

        // Assert
        Assert.AreEqual("Paul", character.name);
    }

    [Test]
    public void Should_add_character_with_health_when_character_build()
    {
        // Arrange
        Character character = new Character();

        // Act
        character = A.Character.WithHealth(100);

        // Assert
        Assert.AreEqual(100, character.health);
    }

    [Test]
    public void Should_add_character_with_strength_when_character_build()
    {
        // Arrange
        Character character = new Character();

        // Act
        character = A.Character.WithStrength(10);

        // Assert
        Assert.AreEqual(10, character.strength);
    }

    [Test]
    public void Should_add_character_with_intelligence_when_character_build()
    {
        // Arrange
        Character character = new Character();

        // Act
        character = A.Character.WithIntelligence(5);

        // Assert
        Assert.AreEqual(5, character.intelligence);
    }

    [Test]
    public void Should_add_weapon_with_name_when_character_build()
    {
        // Arrange
        Character character = new Character();

        Weapon weapon = new Weapon();
        weapon.name = "Sword";

        // Act
        character = A.Character.WithWeapon(weapon);

        // Assert
        Assert.AreEqual("Sword", character.weapon.name);
    }

    [Test]
    public void Should_add_weapon_with_strength_when_character_build()
    {
        // Arrange
        Character character = new Character();

        Weapon weapon = new Weapon();
        weapon.strength = 4;

        // Act
        character = A.Character.WithWeapon(weapon);

        // Assert
        Assert.AreEqual(4, character.weapon.strength);
    }

    [Test]
    public void Should_attack_with_weapon_when_character_attack()
    {
        // Arrange
        Character character = new Character();
        character.strength = 10;

        Weapon weapon = new Weapon();
        weapon.strength = 4;

        character.weapon = weapon;

        // Act
        int value = character.Attack();

        // Assert
        Assert.AreEqual(14, value);
    }

    [Test]
    public void Should_attack_without_weapon_when_character_attack()
    {
        // Arrange
        Character character = new Character();
        character.strength = 10;

        // Act
        int value = character.Attack();

        // Assert
        Assert.AreEqual(10, value);
    }

    [Test]
    public void Should_add_buff_with_strength_when_character_build()
    {
        // Arrange
        Character character = new Character();

        Buff buff = new Buff();
        buff.strength = 2;

        // Act
        character = A.Character.WithBuff(buff);

        // Assert
        Assert.AreEqual(2, character.buff.strength);
    }

    [Test]
    public void Should_add_buff_with_remaining_rounds_when_character_build()
    {
        // Arrange
        Character character = new Character();

        Buff buff = new Buff();
        buff.remainingRounds = 2;

        // Act
        character = A.Character.WithBuff(buff);

        // Assert
        Assert.AreEqual(2, character.buff.remainingRounds);
    }

    [Test]
    public void Should_attack_without_weapon_and_with_buff_when_character_attack()
    {
        // Arrange
        Character character = new Character();
        character.strength = 10;

        Buff buff = new Buff();
        buff.strength = 2;
        buff.remainingRounds = 2;

        character.buff = buff;

        // Act
        int value = character.Attack();

        // Assert
        Assert.AreEqual(12, value);
    }

    [Test]
    public void Should_attack_with_weapon_and_with_buff_when_character_attack()
    {
        // Arrange
        Character character = new Character();
        character.strength = 10;

        Weapon weapon = new Weapon();
        weapon.strength = 4;

        character.weapon = weapon;

        Buff buff = new Buff();
        buff.strength = 2;
        buff.remainingRounds = 2;

        character.buff = buff;

        // Act
        int value = character.Attack();

        // Assert
        Assert.AreEqual(16, value);
    }

    [Test]
    public void Should_attack_with_buff_end_round_when_character_attack()
    {
        // Arrange
        Character character = new Character();

        Buff buff = new Buff();
        buff.remainingRounds = 2;

        character.buff = buff;

        // Act
        character.Attack();

        // Assert
        Assert.AreEqual(1, character.buff.remainingRounds);
    }

    [Test]
    public void Should_attack_with_buff_finish_when_character_attack()
    {
        // Arrange
        Character character = new Character();

        Buff buff = new Buff();
        buff.remainingRounds = 1;

        character.buff = buff;

        // Act
        character.Attack();

        // Assert
        Assert.AreEqual(null, character.buff);
    }
}
