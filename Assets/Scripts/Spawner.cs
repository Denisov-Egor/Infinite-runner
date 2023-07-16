using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] gearVariants;

    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float minTime = 0.65f;

    private void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            int rand = Random.Range(0, gearVariants.Length);
            Instantiate(gearVariants[rand], transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
         }
         else
         {
             timeBtwSpawn -= Time.deltaTime;
         }
    }
}