using static Scripts.Structure;
using static Scripts.Structure.WeaponDefinition;
using static Scripts.Structure.WeaponDefinition.ModelAssignmentsDef;
using static Scripts.Structure.WeaponDefinition.HardPointDef;
using static Scripts.Structure.WeaponDefinition.HardPointDef.Prediction;
using static Scripts.Structure.WeaponDefinition.TargetingDef.BlockTypes;
using static Scripts.Structure.WeaponDefinition.TargetingDef.Threat;
using static Scripts.Structure.WeaponDefinition.HardPointDef.HardwareDef;
using static Scripts.Structure.WeaponDefinition.HardPointDef.HardwareDef.HardwareType;

namespace Scripts
{
    partial class Parts
    {
        // Don't edit above this line
        WeaponDefinition AryxSmallPulseLaser => new WeaponDefinition
        {

            Assignments = new ModelAssignmentsDef
            {
                MountPoints = new[] {
                    new MountPointDef {
                        SubtypeId = "ARYXSmallPulseLaser_Fixed",
                        SpinPartId = "None",
                        MuzzlePartId = "None",
                        AzimuthPartId = "None",
                        ElevationPartId = "None",
                    },
                    
                },
                Muzzles = new[] {
                    "muzzle_projectile_1",
                    "muzzle_projectile_2",

                },
                Ejector = "",
            },
            Targeting = new TargetingDef
            {
                Threats = new[] {
                    Grids,
                },
                SubSystems = new[] {
                    Thrust, Utility, Offense, Power, Production, Any,
                },
                ClosestFirst = true, // tries to pick closest targets first (blocks on grids, projectiles, etc...).
                IgnoreDumbProjectiles = false, // Don't fire at non-smart projectiles.
                LockedSmartOnly = false, // Only fire at smart projectiles that are locked on to parent grid.
                MinimumDiameter = 0, // 0 = unlimited, Minimum radius of threat to engage.
                MaximumDiameter = 0, // 0 = unlimited, Maximum radius of threat to engage.
                MaxTargetDistance = 0, // 0 = unlimited, Maximum target distance that targets will be automatically shot at.
                MinTargetDistance = 0, // 0 = unlimited, Min target distance that targets will be automatically shot at.
                TopTargets = 6, // 0 = unlimited, max number of top targets to randomize between.
                TopBlocks = 0, // 0 = unlimited, max number of blocks to randomize between
                StopTrackingSpeed = 30000000f, // do not track target threats traveling faster than this speed
            },
            HardPoint = new HardPointDef
            {
                PartName = "ZARYA Pulse Laser", // name of weapon in terminal
                DeviateShotAngle = 0.1f, // Inaccuracy in degrees
                AimingTolerance = 0f, // 0 - 180 firing angle
                AimLeadingPrediction = Accurate, // Off, Basic, Accurate, Advanced
                DelayCeaseFire = 10, // Measured in game ticks (6 = 100ms, 60 = 1 seconds, etc..).
                AddToleranceToTracking = false,

                Ui = new UiDef
                {
                    RateOfFire = false,
                    DamageModifier = false,
                    ToggleGuidance = false,
                    EnableOverload = false,
                },
                Ai = new AiDef
                {
                    TrackTargets = false,
                    TurretAttached = false,
                    TurretController = false,
                    PrimaryTracking = false,
                    LockOnFocus = false,
                },
                HardWare = new HardwareDef
                {
                    RotateRate = 0,
                    ElevateRate = 0,
                    MinAzimuth = -0,
                    MaxAzimuth = 0,
                    MinElevation = -0,
                    MaxElevation = 0,
                    FixedOffset = false,
                    InventorySize = 0.0f,
                    Offset = Vector(x: 0, y: 0, z: 0),
                    Type = BlockWeapon, // BlockWeapon, HandWeapon, Phantom 
                    CriticalReaction = new CriticalDef
                    {
                        Enable = false, // Enables Warhead behaviour
                        DefaultArmedTimer = 120,
                        PreArmed = true,
                        TerminalControls = true,
                    },
                },
                Other = new OtherDef
                {
                    ConstructPartCap = 0, // Maximum number of blocks with this weapon on a grid; 0 = unlimited.
                    RotateBarrelAxis = 0, // For spinning barrels, which axis to spin the barrel around; 0 = none.
                    EnergyPriority = 0, // Deprecated.
                    MuzzleCheck = true, // Whether the weapon should check LOS from each individual muzzle in addition to the scope.
                    Debug = false, // Force enables debug mode.
                    RestrictionRadius = 0, // Prevents other blocks of this type from being placed within this distance of the centre of the block.
                    CheckInflatedBox = false, // If true, the above distance check is performed from the edge of the block instead of the centre.
                    CheckForAnyWeapon = false, // If true, the check will fail if ANY weapon is present, not just weapons of the same subtype.
                },
                Loading = new LoadingDef
                {
                    RateOfFire = 300,
                    BarrelSpinRate = 0, // visual only, 0 disables and uses RateOfFire
                    BarrelsPerShot = 1,
                    TrajectilesPerBarrel = 1, // Number of Trajectiles per barrel per fire event.
                    SkipBarrels = 0,
                    ReloadTime = 0, // Measured in game ticks (6 = 100ms, 60 = 1 seconds, etc..).
                    DelayUntilFire = 0, // Measured in game ticks (6 = 100ms, 60 = 1 seconds, etc..).
                    HeatPerShot = 20, //heat generated per shot
                    MaxHeat = 2500, //max heat before weapon enters cooldown
                    Cooldown = 0.95f, //percent of max heat to be under to start firing again after overheat accepts 0.2-0.95
                    HeatSinkRate = 150, //amount of heat lost per second
                    DegradeRof = false, // progressively lower rate of fire after 80% heat threshold (80% of max heat)
                    ShotsInBurst = 0,
                    DelayAfterBurst = 0, // Measured in game ticks (6 = 100ms, 60 = 1 seconds, etc..).
                    FireFull = false,
                    GiveUpAfter = false,
                },
                Audio = new HardPointAudioDef
                {
                    PreFiringSound = "",
                    FiringSound = "ArcWepShipARYX_AuroraFire", // WepShipGatlingShot
                    FiringSoundPerShot = true,
                    ReloadSound = "",
                    NoAmmoSound = "",
                    HardPointRotationSound = "",
                    BarrelRotationSound = "",
                    FireSoundEndDelay = 150, // Measured in game ticks(6 = 100ms, 60 = 1 seconds, etc..).
                },
                Graphics = new HardPointParticleDef
                {

                    Effect1 = new ParticleDef
                    {
                        Name = "", // Smoke_LargeGunShot
                        Color = Color(red: 0, green: 0, blue: 0, alpha: 1),
                        Offset = Vector(x: 0, y: 0, z: -0.25f),

                        Extras = new ParticleOptionDef
                        {
                            Loop = true,
                            Restart = false,
                            MaxDistance = 50,
                            MaxDuration = 6,
                            Scale = 1f,
                        },
                    },
                    Effect2 = new ParticleDef
                    {
                        Name = "Aryx_ATLAS_Muzzleflash",//Muzzle_Flash_Large
                        Color = Color(red: 1, green: 1, blue: 1, alpha: 1),
                        Offset = Vector(x: 0, y: 0, z: -0.25f),

                        Extras = new ParticleOptionDef
                        {
                            Loop = false,
                            Restart = false,
                            MaxDistance = 500,
                            MaxDuration = 0,
                            Scale = 1f,
                        },
                    },
                },
            },
            Ammos = new[] {
                AryxSmallRedLaserAmmo,
            },
            //Animations = AdvancedAnimation,
            // Don't edit below this line
        };
    }
}