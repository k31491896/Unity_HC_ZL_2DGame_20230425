using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

public class DamageEnemy : DamageBasic
{
	private DataEnemy dataEnemy;
	private float probi;
	private void Start()
	{
		probi = Random.value;
		dataEnemy = (DataEnemy)data;
		// print(dataEnemy.expProbability);
	}

	private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("武器"))
        {
            Damage(50);
            
        }
    }

	protected override void Dead()
	{
		base.Dead();
        Destroy(gameObject);

		if (probi < dataEnemy.expProbability)
		{
			Instantiate(dataEnemy.prefabExp, transform.position, transform.rotation);
		}
	}
}