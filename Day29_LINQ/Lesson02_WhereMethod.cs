using System;
using System.Collections.Generic;
using System.Linq;

class ArmorEquipment
{
    public string Name { get; set; }
    public int Defense { get; set; }
}

class LINQWhereDemo
{
    static void Main()
    {
        List<ArmorEquipment> armors = new List<ArmorEquipment>()
        {
            new ArmorEquipment { Name = "Leather Armor", Defense = 20 },
            new ArmorEquipment { Name = "Iron Armor", Defense = 50 },
            new ArmorEquipment { Name = "Dragon Armor", Defense = 90 },
            new ArmorEquipment { Name = "Steel Armor", Defense = 70 },
            new ArmorEquipment { Name = "Cloth Armor", Defense = 10 }
        };

        var strongArmors = armors.Where(armor => armor.Defense >= 50);

        Console.WriteLine("Strong Armors:");

        foreach (var armor in strongArmors)
        {
            Console.WriteLine(armor.Name + " - Defense: " + armor.Defense);
        }
    }
}