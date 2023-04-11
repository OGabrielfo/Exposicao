using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceOptimization : MonoBehaviour
{

    public GameObject[] _salas;
    public float distanciaDoPlayer;
    public float distanciaMaxima;
    private GameObject _player;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < _salas.Length; i++) {
            distanciaDoPlayer = Vector3.Distance(_player.transform.position, _salas[i].transform.position);

            if(distanciaDoPlayer >= distanciaMaxima) {
                _salas[i].SetActive(false);
            } else {
                _salas[i].SetActive(true);
            }
        }
    }
}
