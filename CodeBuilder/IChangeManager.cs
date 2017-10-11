﻿// -----------------------------------------------------------------------
// <copyright company="Fireasy"
//      email="faib920@126.com"
//      qq="55570729">
//   (c) Copyright Fireasy. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace CodeBuilder
{
    public interface IChangeManager
    {
        bool IsChanged { get; }

        void SaveFile();
    }
}
