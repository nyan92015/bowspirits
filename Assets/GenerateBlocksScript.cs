using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBlocks : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Block;
    void Start()
    {
        for (float height = 0; height < 1; height++)
        {
            for (float i = 0; i < 30; i++)
            {
                for (float j = 0; j < 30; j++)
                {
                    GameObject newObject = Instantiate(Block, new Vector3(i, height * 10, j), Quaternion.identity);
                }
            }
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
