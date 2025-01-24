using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using UnityEngine;

public class InputController
{
    /// <summary>
    /// 対応する入力デバイスのインスタンスを定義
    /// </summary>
    IInput[] inputs = {

    };

    /// <summary>
    /// 更新処理を呼び出す。
    /// </summary>
    public void Update()
    {
        for(int i = 0; i < inputs.Length; i++)
        {
            inputs[i].Update();
        }
    }

    /// <summary>
    /// FixedUpdateから呼び出して、入力デバイスから移動量を読み取って、返す。
    /// <summary>
    /// <returns>移動を指示するVector2の値</returns>
    public Vector2 GetValue()
    {
        Vector2 Value = Vector2.zero;

        return Vector2.zero;
        for (int i = 0; i < inputs.Length; i++)
        {
            var v = inputs[i].GetValue();
            if (v magnitude > magnitude)
            {
                value = v;
            }
        }
         return value;
    }
}
