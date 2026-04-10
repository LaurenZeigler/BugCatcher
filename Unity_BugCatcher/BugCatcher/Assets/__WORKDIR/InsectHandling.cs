using UnityEngine;

[CreateAssetMenu(menuName = "wrensScripts/Insect")]
public class InsectInformation : ScriptableObject
{
    /*
     NOTES:
     
     To add: 
     Preferred biome - For spawn nests (+ use taxonomy/species? (butterfly in fields, but moth by lights))
        (solidify biome list !!!)
     species selection making it easier to decide % of time spent walking, flying, swimming, instead of having to make one per entry.... maybe create class per species??
      
     */
    
    
    
    [Header("Refer to code file for explanations")]
    public string insectName; // Full name for display purposes ei: monarch butterfly
    public string insectSpecies; // idk if needed yet, but for catalogue, ei: butterfly
    
    // Taxonomy is used for player cataloging purposes, and not for behavior
    public enum InsectTax
    {
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
    
    public GameObject insectPrefab;
    public Sprite catalogueImage;
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
    
    //
    [Range(0, 1)]
    public float timeWalking;
    [Range(0, 1)]
    public float timeFlying;
    [Range(0, 1)]
    public float timeSwimming;
    [Range(0, 1)]
    public float timeFloatOnSurface;
    public bool hoardingInsect;
    public bool untamable;
}
