using UnityEngine;

public class ScaleDirector : MonoBehaviour
{
    [SerializeField] private float _maxScale;
    [SerializeField] private float _minScale;
    [SerializeField] private float _speed;

    private int _invertFactor = -1;
    private float _currentScale = 1;

    private void Update()
    {
        Resize();
    }

    private void Resize()
    {
        if (_currentScale <= _minScale || _currentScale >= _maxScale)
            _speed *= _invertFactor;

        _currentScale += _speed * Time.deltaTime;
        transform.localScale = Vector3.one * _currentScale;
    }
}