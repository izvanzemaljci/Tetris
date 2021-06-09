using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] tetrominoes = default;
    [SerializeField]
    private SpriteRenderer preview = default;
    private int random = 0;

    void Start()
    {
        random = Random.Range(0, tetrominoes.Length);
        Spawn();
    }

    void Update()
    {
        
    }

    public void Spawn()
    {
        int nextRandom = Random.Range(0, tetrominoes.Length);

        Preview(nextRandom);

        Instantiate(tetrominoes[random],
                transform.position,
                Quaternion.identity);

        random = nextRandom;
    }

    public void Preview(int i) 
    {
        preview.sprite = tetrominoes[i].GetComponent<SpriteRenderer>().sprite;
    }
}
