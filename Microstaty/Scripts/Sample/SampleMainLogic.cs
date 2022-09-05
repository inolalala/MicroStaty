using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Microstaty.Scripts.Sample
{
    public class SampleMainLogic : MonoBehaviour
    {
        [SerializeField] private SampleStateContextMonoBehavior sampleStateContext;
        [SerializeField] private List<Button> _buttons;

        private void Awake()
        {
            sampleStateContext.Initialize();
            
            _buttons[0]?.onClick.AddListener(() => OnClickButtonA());
            _buttons[1]?.onClick.AddListener(() => OnClickButtonB());
            _buttons[2]?.onClick.AddListener(() => OnClickButtonC());
        }

        private void OnClickButtonA()
        {
            sampleStateContext.ChangeState(SampleType.A);
        }
        private void OnClickButtonB()
        {
            sampleStateContext.ChangeState(SampleType.B);
        }
        private void OnClickButtonC()
        {
            sampleStateContext.ChangeState(SampleType.C);
        }
    }
}
