using UnityEngine;

public class OlteanuCameraControl : MonoBehaviour
{
    [SerializeField] Transform target;

    private void Start()
    {
        target = FindObjectOfType<OlteanuPlayerControl>().transform;
    }

    private void LateUpdate()
    {
        transform.position = new Vector3(target.position.x, target.position.y, 0f);
    }
}
