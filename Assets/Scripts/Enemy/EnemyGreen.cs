using UnityEngine;

namespace YoYo.SpaceShooter.Enemy
{
    public class EnemyGreen : Enemy
    {

        private void Update()
        {
            MoveDownward();
        }

        private void MoveDownward()
        {
            Vector3 movement = new Vector3(0, -1, 0) * enemySpeed * Time.deltaTime;
            transform.position += movement;
        }
    }
}