using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    [SerializeField] GameObject cloudPrefab;
    [SerializeField] float secondsSpawn = 5f;
    [SerializeField] float minScreen;
    [SerializeField] float maxScreen;

    private void Start()
    {
        StartCoroutine(CloudTimeSpawner());
    }

    IEnumerator CloudTimeSpawner()
    {

        while (true)
        {
            var wanted = Random.Range(minScreen, maxScreen);
            var position = new Vector3(transform.position.x, wanted);
            GameObject cloud = Instantiate(cloudPrefab, position, Quaternion.identity);
            yield return new WaitForSeconds(secondsSpawn);
            Destroy(cloud, 10f);
        }
        
    }
}
