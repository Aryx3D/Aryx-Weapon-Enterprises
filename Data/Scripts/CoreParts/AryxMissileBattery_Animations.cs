using System.Collections.Generic;
using static Scripts.Structure.WeaponDefinition;
using static Scripts.Structure.WeaponDefinition.AnimationDef;
using static Scripts.Structure.WeaponDefinition.AnimationDef.PartAnimationSetDef.EventTriggers;
using static Scripts.Structure.WeaponDefinition.AnimationDef.RelMove.MoveType;
using static Scripts.Structure.WeaponDefinition.AnimationDef.RelMove;
namespace Scripts
{ // Don't edit above this line
    partial class Parts
    {
        private AnimationDef AryxMissileBatteryAnims => new AnimationDef
        {
            //TODO: Set up missile bay doors (flip open when firing).


            //These are the animation sets the weapon uses in various states.
            AnimationSets = new[]
            {   //Region is used for organisation as it creates a collapsible tag.
				#region Barrels Animations

                new PartAnimationSetDef()
                {
                    SubpartId = Names("missile_1"), //Remember to remove subpart_ from these names!
                    BarrelId = "muzzle_missile_1", //Trigger anim when this muzzle does something.
                    StartupFireDelay = 0, //Delay in ticks until anim starts.
                    AnimationDelays = Delays(FiringDelay: 0, ReloadingDelay: 0, OverheatedDelay: 0, TrackingDelay: 0, LockedDelay: 0, OnDelay: 0, OffDelay: 0, BurstReloadDelay: 0, OutOfAmmoDelay: 0, PreFireDelay: 0),//Delay before animation starts
                    Reverse = Events(),
                    Loop = Events(), //Don't touch these.
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {

                        [Firing] =
                            new[] //Firing, Reloading, Overheated, Tracking, On, Off, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {

                               new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 1, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Hide, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                    LinearPoints = new[]
                                    {
                                        Transformation(0f, 0, 0f), //linear movement in XYZ axes.
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                               new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 600, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Delay, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                    LinearPoints = new[]
                                    {
                                        Transformation(0f, 0, 0f), //linear movement in XYZ axes.
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                               new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 1, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Show, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                    LinearPoints = new[]
                                    {
                                        Transformation(0f, 0, 0f), //linear movement in XYZ axes.
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                            },

                    }

                },
                ///////////////////////////////////////////////////////////////////////////////////////


                new PartAnimationSetDef()
                {
                    SubpartId = Names("missile_2"), //Remember to remove subpart_ from these names!
                    BarrelId = "muzzle_missile_2", //Trigger anim when this muzzle does something.
                    StartupFireDelay = 0, //Delay in ticks until anim starts.
                    AnimationDelays = Delays(FiringDelay: 0, ReloadingDelay: 0, OverheatedDelay: 0, TrackingDelay: 0, LockedDelay: 0, OnDelay: 0, OffDelay: 0, BurstReloadDelay: 0, OutOfAmmoDelay: 0, PreFireDelay: 0),//Delay before animation starts
                    Reverse = Events(),
                    Loop = Events(), //Don't touch these.
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {

                        [Firing] =
                            new[] //Firing, Reloading, Overheated, Tracking, On, Off, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {

                               new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 1, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Hide, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                    LinearPoints = new[]
                                    {
                                        Transformation(0f, 0, 0f), //linear movement in XYZ axes.
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                               new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 600, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Delay, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                    LinearPoints = new[]
                                    {
                                        Transformation(0f, 0, 0f), //linear movement in XYZ axes.
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                               new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 1, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Show, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                    LinearPoints = new[]
                                    {
                                        Transformation(0f, 0, 0f), //linear movement in XYZ axes.
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                            },

                    }

                },
                ///////////////////////////////////////////////////////////////////////////////////////


                new PartAnimationSetDef()
                {
                    SubpartId = Names("missile_3"), //Remember to remove subpart_ from these names!
                    BarrelId = "muzzle_missile_3", //Trigger anim when this muzzle does something.
                    StartupFireDelay = 0, //Delay in ticks until anim starts.
                    AnimationDelays = Delays(FiringDelay: 0, ReloadingDelay: 0, OverheatedDelay: 0, TrackingDelay: 0, LockedDelay: 0, OnDelay: 0, OffDelay: 0, BurstReloadDelay: 0, OutOfAmmoDelay: 0, PreFireDelay: 0),//Delay before animation starts
                    Reverse = Events(),
                    Loop = Events(), //Don't touch these.
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {

                        [Firing] =
                            new[] //Firing, Reloading, Overheated, Tracking, On, Off, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {

                               new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 1, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Hide, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                    LinearPoints = new[]
                                    {
                                        Transformation(0f, 0, 0f), //linear movement in XYZ axes.
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                               new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 600, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Delay, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                    LinearPoints = new[]
                                    {
                                        Transformation(0f, 0, 0f), //linear movement in XYZ axes.
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                               new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 1, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Show, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                    LinearPoints = new[]
                                    {
                                        Transformation(0f, 0, 0f), //linear movement in XYZ axes.
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                            },

                    }

                },                
                ///////////////////////////////////////////////////////////////////////////////////////


                new PartAnimationSetDef()
                {
                    SubpartId = Names("missile_4"), //Remember to remove subpart_ from these names!
                    BarrelId = "muzzle_missile_4", //Trigger anim when this muzzle does something.
                    StartupFireDelay = 0, //Delay in ticks until anim starts.
                    AnimationDelays = Delays(FiringDelay: 0, ReloadingDelay: 0, OverheatedDelay: 0, TrackingDelay: 0, LockedDelay: 0, OnDelay: 0, OffDelay: 0, BurstReloadDelay: 0, OutOfAmmoDelay: 0, PreFireDelay: 0),//Delay before animation starts
                    Reverse = Events(),
                    Loop = Events(), //Don't touch these.
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {

                        [Firing] =
                            new[] //Firing, Reloading, Overheated, Tracking, On, Off, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {

                               new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 1, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Hide, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                    LinearPoints = new[]
                                    {
                                        Transformation(0f, 0, 0f), //linear movement in XYZ axes.
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                               new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 600, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Delay, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                    LinearPoints = new[]
                                    {
                                        Transformation(0f, 0, 0f), //linear movement in XYZ axes.
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                               new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 1, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Show, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                    LinearPoints = new[]
                                    {
                                        Transformation(0f, 0, 0f), //linear movement in XYZ axes.
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                            },

                    }

                },
                ///////////////////////////////////////////////////////////////////////////////////////

                new PartAnimationSetDef()
                {
                    SubpartId = Names("missile_5"), //Remember to remove subpart_ from these names!
                    BarrelId = "muzzle_missile_5", //Trigger anim when this muzzle does something.
                    StartupFireDelay = 0, //Delay in ticks until anim starts.
                    AnimationDelays = Delays(FiringDelay: 0, ReloadingDelay: 0, OverheatedDelay: 0, TrackingDelay: 0, LockedDelay: 0, OnDelay: 0, OffDelay: 0, BurstReloadDelay: 0, OutOfAmmoDelay: 0, PreFireDelay: 0),//Delay before animation starts
                    Reverse = Events(),
                    Loop = Events(), //Don't touch these.
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {

                        [Firing] =
                            new[] //Firing, Reloading, Overheated, Tracking, On, Off, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {

                               new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 1, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Hide, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                    LinearPoints = new[]
                                    {
                                        Transformation(0f, 0, 0f), //linear movement in XYZ axes.
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                               new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 600, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Delay, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                    LinearPoints = new[]
                                    {
                                        Transformation(0f, 0, 0f), //linear movement in XYZ axes.
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                               new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 1, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Show, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                    LinearPoints = new[]
                                    {
                                        Transformation(0f, 0, 0f), //linear movement in XYZ axes.
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                            },

                    }

                },
                ///////////////////////////////////////////////////////////////////////////////////////

                new PartAnimationSetDef()
                {
                    SubpartId = Names("missile_6"), //Remember to remove subpart_ from these names!
                    BarrelId = "muzzle_missile_6", //Trigger anim when this muzzle does something.
                    StartupFireDelay = 0, //Delay in ticks until anim starts.
                    AnimationDelays = Delays(FiringDelay: 0, ReloadingDelay: 0, OverheatedDelay: 0, TrackingDelay: 0, LockedDelay: 0, OnDelay: 0, OffDelay: 0, BurstReloadDelay: 0, OutOfAmmoDelay: 0, PreFireDelay: 0),//Delay before animation starts
                    Reverse = Events(),
                    Loop = Events(), //Don't touch these.
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {

                        [Firing] =
                            new[] //Firing, Reloading, Overheated, Tracking, On, Off, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {

                               new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 1, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Hide, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                    LinearPoints = new[]
                                    {
                                        Transformation(0f, 0, 0f), //linear movement in XYZ axes.
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                               new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 600, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Delay, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                    LinearPoints = new[]
                                    {
                                        Transformation(0f, 0, 0f), //linear movement in XYZ axes.
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                               new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 1, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Show, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                    LinearPoints = new[]
                                    {
                                        Transformation(0f, 0, 0f), //linear movement in XYZ axes.
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                            },

                    }

                },
                ////////////////////////////////////////////
                new PartAnimationSetDef()
                {
                    SubpartId = Names("missile_7"), //Remember to remove subpart_ from these names!
                    BarrelId = "muzzle_missile_7", //Trigger anim when this muzzle does something.
                    StartupFireDelay = 0, //Delay in ticks until anim starts.
                    AnimationDelays = Delays(FiringDelay: 0, ReloadingDelay: 0, OverheatedDelay: 0, TrackingDelay: 0, LockedDelay: 0, OnDelay: 0, OffDelay: 0, BurstReloadDelay: 0, OutOfAmmoDelay: 0, PreFireDelay: 0),//Delay before animation starts
                    Reverse = Events(),
                    Loop = Events(), //Don't touch these.
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {

                        [Firing] =
                            new[] //Firing, Reloading, Overheated, Tracking, On, Off, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {

                               new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 1, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Hide, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                    LinearPoints = new[]
                                    {
                                        Transformation(0f, 0, 0f), //linear movement in XYZ axes.
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                               new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 600, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Delay, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                    LinearPoints = new[]
                                    {
                                        Transformation(0f, 0, 0f), //linear movement in XYZ axes.
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                               new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 1, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Show, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                    LinearPoints = new[]
                                    {
                                        Transformation(0f, 0, 0f), //linear movement in XYZ axes.
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                            },

                    }

                },

                ///////////////////////////////////////////////////////////////////////////////////////

                new PartAnimationSetDef()
                {
                    SubpartId = Names("missile_8"), //Remember to remove subpart_ from these names!
                    BarrelId = "muzzle_missile_8", //Trigger anim when this muzzle does something.
                    StartupFireDelay = 0, //Delay in ticks until anim starts.
                    AnimationDelays = Delays(FiringDelay: 0, ReloadingDelay: 0, OverheatedDelay: 0, TrackingDelay: 0, LockedDelay: 0, OnDelay: 0, OffDelay: 0, BurstReloadDelay: 0, OutOfAmmoDelay: 0, PreFireDelay: 0),//Delay before animation starts
                    Reverse = Events(),
                    Loop = Events(), //Don't touch these.
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {

                        [Firing] =
                            new[] //Firing, Reloading, Overheated, Tracking, On, Off, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {

                               new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 1, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Hide, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                    LinearPoints = new[]
                                    {
                                        Transformation(0f, 0, 0f), //linear movement in XYZ axes.
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                               new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 600, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Delay, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                    LinearPoints = new[]
                                    {
                                        Transformation(0f, 0, 0f), //linear movement in XYZ axes.
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                               new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 1, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Show, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                    LinearPoints = new[]
                                    {
                                        Transformation(0f, 0, 0f), //linear movement in XYZ axes.
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                            },

                    }

                },
                #endregion
            }

        };
    }
}
