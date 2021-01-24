using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float speed = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(0, speed * Time.deltaTime, 0, Space.Self);

        Vector3 curPostion =  Camera.main.WorldToScreenPoint(gameObject.transform.position);
        if(curPostion.y >= Screen.height)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("EnemyPlane"))
        {
            GameObject mainObject = GameObject.Find("/程序主控");
            Main  main = (Main) mainObject.GetComponent("Main");
            main.playBoom();
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }


}
