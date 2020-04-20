﻿// <copyright file="DataInfo.cs" company="Scada International A/S">
// Copyright (c) Scada International A/S. All rights reserved.
// </copyright>

using Prism.Mvvm;

namespace AdalineUI.Misc
{
    public class DataInfo : BindableBase
    {
        private string _name;
        private double _value;

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        public double Value
        {
            get => _value;
            set => SetProperty(ref _value, value);
        }
    }
}