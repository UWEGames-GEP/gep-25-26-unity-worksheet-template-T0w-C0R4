using UnityEngine;

public class Item : MonoBehaviour
{
    public GameObject entity_to_spawn;

    public Interractiveobjects Interractiveobjects_Value;

    public int instance_number = 1;

    void Start()
    {
        SpawnEntities();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void SpawnEntities()
    {
        int current_Spawnpoint_Index = 0;
        for (int i = 0; i< Interractiveobjects_Value.numberOfPrefabsToCreate; i++)
        {
            GameObject currentEntity= Instantiate(entity_to_spawn, Interractiveobjects_Value.SpawnPoint[current_Spawnpoint_Index],Quaternion.identity);

            currentEntity.name = Interractiveobjects_Value.prefab_name + instance_number;

            current_Spawnpoint_Index = (current_Spawnpoint_Index + 1 ) % Interractiveobjects_Value.SpawnPoint.Length;
        }
        
    }
}
