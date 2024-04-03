using UnityEngine;

public class MovingKillZone : MonoBehaviour
{
    [Header("Kill Zone stats")]
    [SerializeField]
    private float _speed;

    private void FixedUpdate()
    {
        this.transform.Translate(Vector3.right * _speed * Time.deltaTime);
        _speed += 0.003f;
    }
}
