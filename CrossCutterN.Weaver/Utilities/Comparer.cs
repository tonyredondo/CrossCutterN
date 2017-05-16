﻿/**
 * Description: Comparer utility
 * Author: David Cui
 */

namespace CrossCutterN.Weaver.Utilities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Aspect;

    internal static class Comparer
    {
        public static bool PointCutEquals(IReadOnlyCollection<JoinPoint> collection1, IReadOnlyCollection<JoinPoint> collection2)
        {
            if(collection1 == null || !collection1.Any())
            {
                throw new ArgumentNullException("collection1");
            }
            if(collection2 == null || !collection2.Any())
            {
                throw new ArgumentNullException("collection2");
            }
            if(collection1.Count != collection2.Count)
            {
                return false;
            }
            var s1 = new HashSet<JoinPoint>(collection1);
            var s2 = new HashSet<JoinPoint>(collection2);
            var e1 = s1.GetEnumerator();
            var e2 = s2.GetEnumerator();
            while(e1.MoveNext())
            {
                e2.MoveNext();
                if(!e1.Current.Equals(e2.Current))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
