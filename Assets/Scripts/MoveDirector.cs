using UnityEngine;

public class MoveDirector : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _direction;
    [SerializeField] private float _maxLengthWay;
    [SerializeField] private bool _isCycle;

    private float _currentLenghtWay = 0;
    private int _inverseFactor = -1;

    private void Update()
    {
        if (_isCycle)
            CycleMove();
        else
            SimpleMove();
    }

    private void CycleMove()
    {
        if (_currentLenghtWay >= _maxLengthWay)
        {
            _currentLenghtWay = 0;
            _speed *= _inverseFactor;
        }

        transform.Translate(_direction * _speed * Time.deltaTime);
        _currentLenghtWay += Time.deltaTime * Mathf.Abs(_speed);
    }

    private void SimpleMove()
    {
        transform.Translate(_direction * _speed * Time.deltaTime);
    }
}