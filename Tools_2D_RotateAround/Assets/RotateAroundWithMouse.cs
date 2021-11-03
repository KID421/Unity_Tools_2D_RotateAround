using UnityEngine;

namespace KID.Tools
{
    /// <summary>
    /// 根據滑鼠座標旋轉物件
    /// </summary>
    public class RotateAroundWithMouse : MonoBehaviour
    {
        [Header("要根據滑鼠旋轉的物件")]
        public Transform target;

        /// <summary>
        /// 滑鼠在世界空間的座標，Z 軸與要旋轉物件相同
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
        /// 旋轉
        /// </summary>
        private void Rotate()
        {
            target.right = positionMouse - target.position;
        }
    }
}