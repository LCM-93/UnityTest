using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlaneCtrl : MonoBehaviour
{

    public GameObject enemyPlanePrefab;
    public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("createEnemyPlane", 0.1f, 1.5f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void createEnemyPlane()
    {
        float targetX = Random.Range(-20, 20);
        Vector3 pos = new Vector3(targetX / 10.0f, 5, 0);
        GameObject enemyPlane = Instantiate(enemyPlanePrefab);
        enemyPlane.transform.position = pos;

        int index = Random.Range(0, sprites.Length);
       SpriteRenderer renderer =  enemyPlane.GetComponent<SpriteRenderer>();
        renderer.sprite = sprites[index];
    }
}
