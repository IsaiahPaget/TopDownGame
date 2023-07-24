using UnityEngine;

[CreateAssetMenu(fileName = "FireBallSO", menuName ="ScriptableObjects/FireBallSO")]
public class FireBall : Spell
{
    GameObject _fireBall;
    private Camera _mainCamera;
    private Transform _playerTransform;

    public override void Cast()
    {
        _playerTransform = GameObject.Find("Player").transform;
        GameObject cameraObject = GameObject.Find("Main Camera");
        if (cameraObject != null)
        {
            _mainCamera = cameraObject.GetComponent<Camera>();
        }
        Vector2 mousePosition = _mainCamera.ScreenToWorldPoint(Input.mousePosition);
        Vector2 firePointPosition = _playerTransform.position;
        Vector2 direction = mousePosition - firePointPosition;
        direction.Normalize();

        _fireBall = Instantiate(_prefab, _playerTransform.position, Quaternion.identity);

        Rigidbody2D rigidbody = _fireBall.GetComponent<Rigidbody2D>();
        rigidbody.velocity = direction * _speed;
        
    }
}