using UnityEngine;

[CreateAssetMenu(fileName = "template", menuName = "wrensScripts/template")]
public class TEMPLATE : ScriptableObject
{
    [Header("Header")]

    public string inputString;

    [Range(0, 1)] public float inputPercentage;

    public GameObject inputGameObject;
    
    public Sprite inputSprite;
    
    
    public enum SelectVar
    {
        var1,
        var2,
        var3
    }
    public SelectVar selectOne;
    
    
    
    [System.Flags]
    public enum MultipleVarSelect
    {
     None = 0,
     var1 = 1,
     var2 = 2,
     var3 = 4,
     var4 = 8,
     var5 = 16,
     var6 = 32,
     var7 = 64,
     var8 = 128,
     var9 = 256,
     var10 = 512,
     var11 = 1024,
     var12 = 2048,
     var13 = 4096
     }
    public MultipleVarSelect selectMultiple;
    
    
    
    [System.Serializable]
    public class MultipleEntries
    {
        public string inputStringClass;
        
        public GameObject inputGameObjectClass;
    
        public Sprite inputSpriteClass;
        
        
        public enum SelectVarClass
        {
            var1,
            var2,
            var3
        }
        public SelectVarClass selectOneClass;
        
        
        [System.Flags]
        public enum MultipleVarSelectClass
        {
            None = 0,
            var1 = 1,
            var2 = 2,
            var3 = 4,
            var4 = 8,
            var5 = 16,
            var6 = 32,
            var7 = 64,
            var8 = 128,
            var9 = 256,
            var10 = 512,
            var11 = 1024,
            var12 = 2048,
            var13 = 4096
        }
        public MultipleVarSelectClass selectMultipleClass;
    }
    public MultipleEntries[] stringList;
}
