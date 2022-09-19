using System;

namespace PropertiesConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Player tom = new Player();
            Console.WriteLine(tom.health);
            tom.damage(30);
            Console.WriteLine(tom.health);
            tom.health = 20;
            Console.WriteLine(tom.health);
            tom.health += 400;
            Console.WriteLine(tom.health);


            Console.ReadKey();
        }


        class Player
        {
            private int maxHealth = 100;
            private int _health = 100; //Default
            public int health {
                get
                {
                    return _health;
                }

                set
                {
                    if (value <= 0)
                    {
                        _health = 0;
                    }else if (value>= maxHealth)
                    {
                        _health = maxHealth;
                    }
                    else
                    {
                        _health = value;
                    }
                    
                }
            }

            public void damage(int _dmg)
            {
                _health -= _dmg;
            }
        }
    }
}
