﻿/**
 * Description: read only custom attribute interface
 * Author: David Cui
 */

namespace CrossCutterN.Advice.Parameter
{
    using System.Collections.Generic;

    public interface ICustomAttribute
    {
        string TypeName { get; }
        int Sequence { get; }
        IReadOnlyCollection<IAttributeProperty> Properties { get; }
        IAttributeProperty GetProperty(string name);
        bool HasProperty(string name);
    }
}
