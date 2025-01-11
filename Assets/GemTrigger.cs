using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemTrigger : MonoBehaviour
{

    bool noDiamondThere;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine((AutomaticDestroyDiamond(4f)));

    }

    // Update is called once per frame
    void Update()
    {
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            GemSpawning gemSpawning = FindAnyObjectByType<GemSpawning>();
            gemSpawning.DiamondVanish();
            Destroy(gameObject);
            noDiamondThere = true;


        }
    }

    private IEnumerator AutomaticDestroyDiamond(float delay)
    {
        yield return new WaitForSeconds(delay);

        if (!noDiamondThere)
        {
            Destroy(gameObject);
            GemSpawning gemSpawning = FindAnyObjectByType<GemSpawning>();
            gemSpawning.DiamondVanish();
        }

    }
}
