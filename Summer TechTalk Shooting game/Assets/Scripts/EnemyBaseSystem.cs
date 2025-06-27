using UnityEngine;

public class EnemyBaseSystem : MonoBehaviour
{
    [Header("出現範囲")]
    public Vector2 Range;
    [Header("出現中心位置")]
    public Vector3 Position; 
    [Header("出現頻度")]
    public float ApperInterval;
    float CT;
    [Header("敵プレハブ")]
    public GameObject EnemyPrefab;

    // Update is called once per frame
    void Update()
    {
        if (CT < ApperInterval)
            CT += Time.deltaTime;
        else
        {
            CT = 0;
            GameObject Enemy = Instantiate(EnemyPrefab, Position + (Vector3.right * Random.Range(Range.x, Range.y)), Quaternion.identity);
        }
    }
}
