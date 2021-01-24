using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlane : MonoBehaviour
{

    private float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       gameObject.transform.Translate(0,-(speed*Time.deltaTime),0,Space.Self);

       Vector3 pos =  Camera.main.WorldToScreenPoint(this.transform.position);

        if(pos.y <= 0)
        {
            Destroy(this.gameObject);
        }
    }

}
