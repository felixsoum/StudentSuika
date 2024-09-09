using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 3;

    public GameObject ballPrefab;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = 0;// Input.GetAxis("Vertical");
        transform.position += new Vector3(x, y, 0) * Time.deltaTime * speed;

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ballPrefab, transform.position, Quaternion.identity);
        }
    }
}
