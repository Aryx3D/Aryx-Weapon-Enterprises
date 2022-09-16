using static Scripts.Structure;
using static Scripts.Structure.ArmorDefinition.ArmorType;
namespace Scripts {   
    partial class Parts {
        // Don't edit above this line
        ArmorDefinition AryxHeavierTurretArmour => new ArmorDefinition
        {
            SubtypeIds = new[] {
                "ARYXTyphoonCannon",
                "ARYXReaperPulseCannon",
                "ARYXMagnetarCannon",
                "ARYXGaussTurret",
            },
            EnergeticResistance = 1.5f, //Resistance to Energy damage. 0.5f = 200% damage, 2f = 50% damage
            KineticResistance = 1.5f, //Resistance to Kinetic damage. Leave these as 1 for no effect
            Kind = Heavy, //Heavy, Light, NonArmor - which ammo damage multipliers to apply
        };
        ArmorDefinition AryxHeavyTurretArmour => new ArmorDefinition
        {
            SubtypeIds = new[] {
                "ARYXMissileBattery",
                "ARYXQuasarCannon",
                "ARYXHurricaneCannon",
                "ARYXPlasmaBeamCannon",
            },
            EnergeticResistance = 1.25f, //Resistance to Energy damage. 0.5f = 200% damage, 2f = 50% damage
            KineticResistance = 1.25f, //Resistance to Kinetic damage. Leave these as 1 for no effect
            Kind = Heavy, //Heavy, Light, NonArmor - which ammo damage multipliers to apply
        };

    }
}