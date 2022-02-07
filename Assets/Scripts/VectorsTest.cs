using UnityEngine;

public class VectorsTest : MonoBehaviour
{
    [Header("Vector Inputs to Find Volume")]
    [SerializeField] private Vector3 _vector1;
    [SerializeField] private Vector3 _vector2;
    [SerializeField] private Vector3 _vector3;

    void Start()
    {
        Coordinates vector1 = new Coordinates(_vector1);
        Coordinates vector2 = new Coordinates(_vector2);
        Coordinates vector3 = new Coordinates(_vector3);

        float volume = Mathematics.Volume(vector1, vector2, vector3);
        Debug.Log("Volume is : " + volume);
    }
}
