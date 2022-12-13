using UnityEngine;
using CreatorKitCode;

public class SpawnerSample : MonoBehaviour
{
    public GameObject ObjectToSpawn;

    void Start()
    {
        // the angle that is added to every spawn position; i.e. 0, 45, 90, 135, etc)
        LootAngle myLootAngle = new LootAngle(45);

        SpawnPotion(myLootAngle.NextAngle());
        SpawnPotion(myLootAngle.NextAngle());
        SpawnPotion(myLootAngle.NextAngle());
        SpawnPotion(myLootAngle.NextAngle());
    }
    
    // the function for spawning health potions
    void SpawnPotion(int angle)
    {
        // the radius of the spawn
        int radius = 4;

        Vector3 direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        Vector3 spawnPosition = transform.position + direction * radius;
        Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);
    }
}

public class LootAngle
{
    int angle;
    int step;

    public LootAngle(int increment)
    {
        step = increment;
        angle = 0;
    }

    // the function for calculating the new angle for new potions
    public int NextAngle()
    {
        int currentAngle = angle;
        angle = Helpers.WrapAngle(angle + step);

        return currentAngle;
    }
}

