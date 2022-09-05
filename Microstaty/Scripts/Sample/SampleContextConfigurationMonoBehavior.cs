using System;
using System.Collections.Generic;
using Microstaty.Scripts.CSharp;
using Microstaty.Scripts.Interface;
using Microstaty.Scripts.MonoBehavior;
using Microstaty.Scripts.Helper;
using UnityEngine;
using UnityEngine.UI;

namespace Microstaty.Scripts.Sample
{
    public class SampleContextConfigurationMonoBehavior :  ContextConfigurationMonoBehaviorBase<SampleType>
    {
        [SerializeField] private Text debugText;

        public override StateContextConfig<SampleType> Set()
        {
            //Stateインターフェースを持つオブジェクトを辞書登録
            Dictionary<SampleType, IState> stateObjDic = new Dictionary<SampleType, IState>();
            for (int i = 0; i < stateObjects.Length; i++)
            {
                StateMonoBehaviorBase<SampleType> stateMonoBehaviorObj = stateObjects[i];
                stateObjDic.Add(stateMonoBehaviorObj.StateType, stateMonoBehaviorObj.GetMyStateType());
            }
            
            //OnEnter時の処理を辞書登録。
            Dictionary<SampleType, Action> onEnterHandlerDic = new Dictionary<SampleType, Action>();
            onEnterHandlerDic.Add(SampleType.A, () =>
            {
                Debug.Log("Enter A");
                debugText.text = "A";
            });
            onEnterHandlerDic.Add(SampleType.B, () =>
            {
                Debug.Log("Enter B");
                debugText.text = "B";
            });
            onEnterHandlerDic.Add(SampleType.C, () =>
            {
                Debug.Log("Enter C");
                debugText.text = "C";
            });
            
            //OnExit時の処理を辞書登録。
            Dictionary<SampleType, Action> onExitHandlerDic = new Dictionary<SampleType, Action>();
            onExitHandlerDic.Add(SampleType.A, () =>
            {
                Debug.Log("Exit StateA");
            });
            onExitHandlerDic.Add(SampleType.B, () =>
            {
                Debug.Log("Exit StateB");
            });
            onExitHandlerDic.Add(SampleType.C, () =>
            {
                Debug.Log("Exit StateC");
            });
            
            //configオブジェクトにまとめる。
            StateContextConfig<SampleType> config =
                new StateContextConfig<SampleType>(stateObjDic, onEnterHandlerDic, onExitHandlerDic);

            return config;
        }
    }
}
