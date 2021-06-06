using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] tetrominoes = default;

    void Start()
    {
        Spawn();
    }

    void Update()
    {
        
    }

    void Spawn()
    {
        int i = Random.Range(0, tetrominoes.Length);

        Instantiate(tetrominoes[i],
                transform.position,
                Quaternion.identity);
    }
}
