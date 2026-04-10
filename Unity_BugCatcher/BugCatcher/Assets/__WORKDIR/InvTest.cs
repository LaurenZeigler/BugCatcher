using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Inventory to store:
Currency
Equipped bugNet
Inventory bugNets

List of: bugBait
List of: bugTraps
List of: bugFood
List of: carriedBugs

Other objects:
    1 bug Cage:
        private bool hasBug = false;
        store: bug
    bug:
        name
        hunger (if wild, false)
        size (randomize when spawned)
        
        Bug classes:
            type
                movementType
                wildBehavior
                tamedBehavior
                

*/


public class InvTest : MonoBehaviour
{
    public ScriptableObject data;
    // (score)
    
    private void SaveData<T>(T obj) where T : Object
    {
        if (obj == null) return;
        PlayerPrefs.SetString(obj.name, JsonUtility.ToJson(obj));
    }
    private void LoadData<T>(T obj) where T : Object
    {
        if ( obj == null) return;
        var jsonData = PlayerPrefs.GetString(obj.name);
        if (!string.IsNullOrEmpty(jsonData))
            JsonUtility.FromJsonOverwrite(jsonData, obj);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
