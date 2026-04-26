using UnityEngine;

[CreateAssetMenu(fileName = "Insect", menuName = "wrensScripts/Insect")]
public class InsectInformation : ScriptableObject
{
    [Header("Refer to code file for explanations")]
    
    public string insectSpecies; // idk if needed yet, but for catalogue, ei: butterfly
    
    // Taxonomy is used for player cataloging purposes, and not for behavior
    public enum InsectTax
    {
        Uncategorized,
        Annelida, // worms, leaches
        Arachnid, // spiders, mites, scorpion
        Blattodea, // cockroach
        Coleoptera, // ants, beetles, aphids
        Hymenoptera, // bee, wasp, fly
        Lepidoptera, // butterfly, moth, caterpillar
        Malacostraca, // hermit crab, isopod
        Mantodea, // mantis
        Mollusca, // snail, slug
        Myriapoda, // millipede, centipede
        Odonata // dragonfly, damselfly
    }
    public InsectTax insectTaxonomy;
    [System.Serializable]
    public class SpecificInsects
    {
        public string insectName; // Full name for display purposes ei: monarch butterfly

        // 
        /*
         TEMPORARY NOTE
         template for creating multiple selection enums
         
        [System.Flags]
        public enum
        {
         None = 0,
         = 1,
         = 2,
         = 4,
         = 8,
         = 16,
         = 32,
         = 64,
         = 128,
         = 256,
         = 512,
         = 1024,
         = 2048,
         = 4096
         }
        public
        */
        [System.Flags]
        public enum PreferredBiome
        {
            None = 0,
            Beach = 1,
            Ocean = 2,
            River = 4,
            Marsh = 8,
            Meadow = 16,
            Forest = 32,
            Mountain = 64,
            Rocky = 128,
            Desert = 256,
            Ruins = 512,
            Settlement = 1024
        }
        public PreferredBiome preferredBiome;
        [System.Flags]
        public enum PrefSpawners
        { 
            None = 0,
            Darkness = 1,
            Light = 2,
            Flowers = 4,
            Nest = 8, // for bees and ants, prioritize selecting nest only (if wandering is figured out)
            Detritus = 16,
            Wood = 32,
            Rock = 64,
            Dirt = 128,
            Sand = 256,
            Water = 512
        }
        public PrefSpawners preferredSpawners;
        public GameObject insectPrefab;
        public Sprite catalogueImage;
    }
    public SpecificInsects[] insectsOfThisSpecies;

    public enum BehaviorWild
    {
        Peaceful, // 
        Nuisance,
        Predator,
        Pest
    }
    public BehaviorWild wildBehavior;

    public enum BehaviorTamed
    {
        Tender,
        Pollinator,
        Protector,
        Pest
    }
    public BehaviorTamed tamedBehavior;
    
    // right now a LOT but bare with me i think ill need them...?
    [Range(0, 1)] public float timeIdling;
    [Range(0, 1)] public float timeWalking;
    [Range(0, 1)] public float timeFlying;
    public bool climbWalls;
    [Range(0, 1)] public float timeSwimming;
    [Range(0, 1)] public float timeFloatOnSurface;
    public bool hoardingInsect;
    public bool untamable;


}
