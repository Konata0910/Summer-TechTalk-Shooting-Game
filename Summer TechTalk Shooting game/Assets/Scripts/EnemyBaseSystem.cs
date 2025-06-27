using UnityEngine;

public class EnemyBaseSystem : MonoBehaviour
{
    [Header("�o���͈�")]
    public Vector2 Range;
    [Header("�o�����S�ʒu")]
    public Vector3 Position; 
    [Header("�o���p�x")]
    public float ApperInterval;
    float CT;
    [Header("�G�v���n�u")]
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
