using System;

public class Character
{
    public string name;
    public int health;
    public int strength;
    public int intelligence;
    public Weapon weapon;
    public Buff buff;

    public int Attack()
    {
        int attack = strength;

        // Possess Weapon
        if (weapon != null)
        {
            attack += weapon.strength;
        }

        // Possess Buff
        if (buff != null)
        {
            attack += buff.strength;

            buff.remainingRounds = Math.Max(buff.remainingRounds - 1, 0);

            if(buff.remainingRounds <= 0)
            {
                buff = null;
            }   
        }

        return attack;
    }
}
