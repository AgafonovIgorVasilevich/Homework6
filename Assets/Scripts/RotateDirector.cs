using UnityEngine;

public class RotateDirector : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _direction;

    private void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.Rotate(_direction * _speed * Time.deltaTime);
    }
}