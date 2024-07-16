﻿using Microsoft.CodeAnalysis;

namespace Maui.BindableProperty.Generator.Core.BindableProperty.Implementation.Interfaces;

public interface IImplementation
{
    bool SetterImplemented();
    string ProcessBindableParameters();
    void ProcessBodySetter(CodeWriter w);
    void ProcessImplementationLogic(CodeWriter w);
}
