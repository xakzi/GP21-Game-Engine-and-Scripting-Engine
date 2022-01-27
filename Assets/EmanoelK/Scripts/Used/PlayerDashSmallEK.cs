using System.Collections;
using UnityEngine;

namespace EmanoelK.Scripts
{
    public class PlayerDashSmallEK : MonoBehaviour
    {
        public float _dashTime = 0.1f;
        public float _dashSpeed = 10f;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                StartCoroutine(DashCoroutine());
            }
        }
    
        private IEnumerator DashCoroutine()
        {
            float startTime = Time.time; // need to remember this to know how long to dash
            while (Time.time < startTime + _dashTime)
            {
                if (Input.GetKey(KeyCode.D))
                    transform.Translate(transform.right * _dashSpeed * Time.deltaTime);
                if (Input.GetKey(KeyCode.A))
                    transform.Translate(transform.right * -_dashSpeed * Time.deltaTime);
                // or controller.Move(...), dunno about that script
                yield return null; // this will make Unity stop here and continue next frame
            }
        }
    }
}
