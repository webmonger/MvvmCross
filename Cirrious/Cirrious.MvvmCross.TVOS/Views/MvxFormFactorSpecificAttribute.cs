// MvxFormFactorSpecificAttribute.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using System;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.TVOS.Platform;
using Cirrious.CrossCore.IoC;

namespace Cirrious.MvvmCross.TVOS.Views
{
    [AttributeUsage(AttributeTargets.Class)]
    public class MvxFormFactorSpecificAttribute
        : MvxConditionalConventionalAttribute
    {
        public MvxFormFactorSpecificAttribute(MvxTouchFormFactor target)
        {
            Target = target;
        }

        public MvxTouchFormFactor Target { get; private set; }

        public override bool IsConditionSatisfied
        {
            get
            {
                var properties = Mvx.Resolve<IMvxTouchPlatformProperties>();
                return (properties.FormFactor == Target);
            }
        }
    }
}