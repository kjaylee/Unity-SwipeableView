﻿using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SwipeableView
{
    public class SceneExample01 : MonoBehaviour
    {
        [SerializeField]
        private UISwipeableViewExample01 swipeableView;

        void Start()
        {
            var data = Enumerable.Range(0, 10)
                                 .Select(i => new CardDataExample01
                                    {
                                        color = Color.Lerp(Color.blue, Color.green, i / 10) 
                                    })
                                 .ToList();

            swipeableView.UpdateData(data);
        }
    }
}
