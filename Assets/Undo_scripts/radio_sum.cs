using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnotherScript : MonoBehaviour
{
    void Start()
    {
        // 例えば、初期化時に100を加える
        sum_score.AddToSum(100);

        // 他の操作に応じて値を加える
        sum_score.DecToSum(100);
    }


}
