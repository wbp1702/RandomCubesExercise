using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCubesExercise : MonoBehaviour
{
    public GameObject cubePrefab;

    // Start is called before the first frame update
    void Start()
    {
        //print("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        //print("Hello World");

        GameObject cube = Instantiate(cubePrefab);
        Material mat = cube.GetComponent<MeshRenderer>().material;
        mat.color = Random.ColorHSV(0, 1, 0.5f, 1, 0.75f, 1);
    }
}
