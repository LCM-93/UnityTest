using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jet : MonoBehaviour
{

    private float bulletInterval = 0.4f;
    private float count;
    public GameObject bulletPrefab;
    private float moveSpeed = 2.5f;
    private bool isMounseDown = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;
        if (count >= bulletInterval)
        {
            createBullet();
            count = 0f;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-(moveSpeed * Time.deltaTime), 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate((moveSpeed * Time.deltaTime), 0, 0);
        }

        if (Input.GetMouseButtonDown(0))
        {
            isMounseDown = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            isMounseDown = false;
        }
        if (isMounseDown)
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 curPostion = transform.position;
            curPostion.x = pos.x;
            transform.position = curPostion;
        }
    }

    private void createBullet()
    {
        Vector3 pos = transform.position + new Vector3(0, 0.5f, 0);
        GameObject bullet = Instantiate(bulletPrefab, pos, transform.rotation);
    }
}
