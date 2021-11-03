using UnityEngine;

namespace KID.Tools
{
    /// <summary>
    /// �ھڷƹ��y�б��ફ��
    /// </summary>
    public class RotateAroundWithMouse : MonoBehaviour
    {
        [Header("�n�ھڷƹ����઺����")]
        public Transform target;

        /// <summary>
        /// �ƹ��b�@�ɪŶ����y�СAZ �b�P�n���ફ��ۦP
        /// </summary>
        public Vector3 positionMouse
        {
            get
            {
                Vector3 pos = Input.mousePosition;
                pos = Camera.main.ScreenToWorldPoint(pos);
                pos.z = target.position.z;
                return pos;
            }
        }

        private void Update()
        {
            Rotate();
        }

        /// <summary>
        /// ����
        /// </summary>
        private void Rotate()
        {
            target.right = positionMouse - target.position;
        }
    }
}