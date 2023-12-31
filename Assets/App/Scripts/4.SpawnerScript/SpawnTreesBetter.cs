using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTreesBetter : MonoBehaviour
{
    public int numberToSpawn;
    public List<GameObject> spawnPoolArboles;
    //public GameObject spawnerArea;

    public void SpawnObjects()
    {
        int randomItem = Random.Range(0, spawnPoolArboles.Count);
        GameObject toSpawn;
        //MeshCollider meshCollider = spawnerArea.GetComponent<MeshCollider>();

        //float screenX, screenY;
        //Vector2 pos;

        /*for (int i = 0; i < numberToSpawn; i++)
        {
            randomItem = Random.Range(0, spawnPoolArboles.Count);
            toSpawn = spawnPoolArboles[randomItem];

            //screenX = Random.Range(meshCollider.bounds.min.x, meshCollider.bounds.max.x);
            //screenY = Random.Range(meshCollider.bounds.min.y, meshCollider.bounds.max.y);
            //pos = new Vector2(screenX, screenY);

            Instantiate(toSpawn, toSpawn.transform.position, toSpawn.transform.rotation);
        }*/

        //randomItem = Random.Range(0, spawnPoolArboles.Count);
        toSpawn = spawnPoolArboles[randomItem];
        toSpawn.SetActive(true);
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Park_Level/Trees Growing");
        //Debug.Log("Se spawneo unos arboles");
    }

    public void DestroyTrees()
    {
        GameObject.FindWithTag("SpawnableArbol").SetActive(false);
    }
}
