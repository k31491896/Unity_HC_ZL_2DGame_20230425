using UnityEngine;

public class exps : MonoBehaviour
{
    [Header("移動速度"), Range(0, 10)]
    public float speed = 2.5f;
    [Header("被吃掉的距離"), Range(0, 3)]
    public float disEat = 0.4f;
    [Header("經驗值"), Range(0, 500)]
    public float expexp = 30;
    private Transform player;
    private LevelManager levelmanager;

    private void Awake()
    {
        player = GameObject.Find("爆走企鵝").transform;
        levelmanager = player.GetComponent<LevelManager>();
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
		if (Vector3.Distance(transform.position,player.position) < disEat)
		{
            levelmanager.Addexp(expexp);
            Destroy(gameObject);
		}
    }
}
