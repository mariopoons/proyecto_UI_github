using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicVolumen : MonoBehaviour
{
    private AudioSource _audioSource;

    public GameObject cam;

    public Vector3 _vector3;

    public GameObject cube;

    private void Start()
    {
        _audioSource = cam.GetComponent<AudioSource>();

        _vector3 = cube.GetComponent<Transform>().localScale;
    }

    public void MusicValue(float value, float scale)
    {
        _audioSource.volume = value;
        
    }
}