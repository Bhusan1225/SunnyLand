using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemSpawning : MonoBehaviour
{

    bool isDiamondthere;
    

    [Header ("Diamond")]
    public GameObject diamondPrefab;
    public float DiamondVanishingTime;

    [Header ("Diamond Spawning Area")]
    public Vector2 minSpawnPos;
    public Vector2 maxSpawnpos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        
    }

    void SpawnDiamond()
    {
        while(!isDiamondthere)
        {
            isDiamondthere = true;

            Vector2 DamondRandomPos = new Vector2(Random.Range(minSpawnPos.x, maxSpawnpos.x), Random.Range(minSpawnPos.y, maxSpawnpos.y));
            
            Instantiate(diamondPrefab, DamondRandomPos, diamondPrefab.transform.rotation);
            Invoke(nameof(DiamondVanish), DiamondVanishingTime);

        }

        void DiamondVanish()
        {
            Destroy(diamondPrefab);
            isDiamondthere = false;
            
        }
    }
}