using UnityEngine;
using UnityEngine.Splines;

public class FollowPath : MonoBehaviour
{
    public float speed;
    float t = 0;
    public SplineContainer splineContainer;
    void Start()
    {
    }
    void Update()
    {
        
        Spline spline = splineContainer.Spline;
        t += Time.deltaTime * speed;
        var localPosition = spline.EvaluatePosition(t);
        transform.position = splineContainer.transform.TransformPoint(localPosition);        
    }
    void OnMouseDown()
{
    Destroy(gameObject);
}
}