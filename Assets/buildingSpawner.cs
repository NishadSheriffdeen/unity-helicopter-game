using UnityEngine;

public class buildingSpawner : MonoBehaviour
{

    public GameObject building;
    public float spawnRate = 2;
    private float timer = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnBuilding();
    }

    // Update is called once per frame
    void Update()
    {

        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnBuilding();
            timer = 0;
        }


    }

    void spawnBuilding()
    {
        Instantiate(building, transform.position, transform.rotation);
    }
}
