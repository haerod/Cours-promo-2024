using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public static Generator instance;
    public List<Biome> biomes;
    public int count;
    public Vector3 baseCoordinates;

    private void Awake()
    {
        if (!instance)
            instance = this;
    }

    private void Start()
    {
        Generate();
    }

    public void Generate()
    {
        GameObject instaChunk = null;

        for (int i = 0; i < count; i++)
        {
            Vector3 poz = baseCoordinates;

            if (i > 0)
            {
                poz = GetBounds(instaChunk).center + (Vector3.right * GetBounds(instaChunk).extents.x);
            }

            //instaChunk = Instantiate(chunkPrefabs[Random.Range(0, chunkPrefabs.Count)], Vector3.zero , Quaternion.identity);
            //instaChunk.transform.position = poz + (Vector3.right * GetBounds(instaChunk).extents.x);
        }
    }

    private Bounds GetBounds(GameObject o)
    {
        Renderer rend = o.GetComponentInChildren<Renderer>();
        return rend.bounds;
    }
}

[System.Serializable]
public class Biome
{
    public string description;
    public List<GameObject> chunks;
    public List<GameObject> transition;
    public int count;
    public int currentCount;
    public bool infinity;

    public int GetIndex()
    {
        return Generator.instance.biomes.IndexOf(this);
    }
}