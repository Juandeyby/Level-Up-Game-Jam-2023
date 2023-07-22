using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerArboles : MonoBehaviour
{
    public int numberToSpawn;
    public List<GameObject> spawnPool;
    public GameObject spawnerArea;

    public void SpawnObjects()
    {
        int randomItem = 0;
        GameObject toSpawn;
        MeshCollider meshCollider = spawnerArea.GetComponent<MeshCollider>();

        float screenX, screenY;
        Vector2 pos;

        for (int i=0; i<numberToSpawn; i++)
        {
            randomItem = Random.Range(0, spawnPool.Count);
            toSpawn = spawnPool[randomItem];

            screenX = Random.Range(meshCollider.bounds.min.x, meshCollider.bounds.max.x);
            screenY = Random.Range(meshCollider.bounds.min.y, meshCollider.bounds.max.y);
            pos = new Vector2(screenX, screenY);

            Instantiate(toSpawn, pos, toSpawn.transform.rotation);
        }
    }

    public void DestroyTrees()
    {
        Destroy(GameObject.FindWithTag("SpawnableArbol"));
    }
}
