﻿namespace SMT.SaaS.OA.UI
{
    using System;
    using System.ComponentModel;
    using System.Globalization;
    using System.Windows.Browser;
    using SMT.SaaS.OA.UI.Assets.Resources;

    /// <summary>
    ///     Wraps access to the strongly typed resource classes so that you can bind
    ///     control properties to resource strings in XAML
    /// </summary>
    public sealed class ResourceWrapper
    {
        private static ApplicationStrings applicationStrings = new ApplicationStrings();
        //private static SecurityQuestions securityQuestions = new SecurityQuestions();

        public ApplicationStrings ApplicationStrings
        {
            get { return applicationStrings; }
        }

        //public SecurityQuestions SecurityQuestions
        //{
        //    get { return securityQuestions; }
        //}
    }
}
