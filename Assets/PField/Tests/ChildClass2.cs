using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;

namespace EnesShahn.PField.Tests
{
    public class ChildClass2 : BaseClass
    {
        [Header("Child Class 2")]
        public float ChildFloatVar;
        [SerializeField] private List<float> ChildFloatListVar;
        [SerializeField] private List<ChildClass2Struct> ChildStructVar;
    }

    [Serializable]
    public class ChildClass2Struct
    {
        [Header("Child Class 2 Struct")]
        public float FloatVar;
    }
}