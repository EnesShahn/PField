using System;
using System.Collections.Generic;

using UnityEngine;

namespace EnesShahn.PField.Tests
{
    public class ChildClass3 : BaseClass
    {
        [SerializeField] private List<string> StringListVar = new List<string>();
        [SerializeField] private float ChildFloatVar;
    }
}