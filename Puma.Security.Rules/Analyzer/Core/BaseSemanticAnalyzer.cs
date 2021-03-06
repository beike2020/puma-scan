﻿/* 
 * Copyright(c) 2016 - 2019 Puma Security, LLC (https://www.pumascan.com)
 * 
 * Project Leader: Eric Johnson (eric.johnson@pumascan.com)
 * Lead Developer: Eric Mead (eric.mead@pumascan.com)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/. 
 */

using System.Collections.Concurrent;

using Microsoft.CodeAnalysis.Diagnostics;

using Puma.Security.Rules.Common;
using Puma.Security.Rules.Core;

namespace Puma.Security.Rules.Analyzer.Core
{
    internal class BaseSemanticAnalyzer
    {
        public ConcurrentStack<VulnerableSyntaxNode> VulnerableSyntaxNodes { get; } =
            new ConcurrentStack<VulnerableSyntaxNode>();

        public virtual void GetSinks(SyntaxNodeAnalysisContext context, DiagnosticId ruleId)
        {

        }

        public virtual void OnCompilationEnd(PumaCompilationAnalysisContext context)
        {
            
        }
    }
}
