﻿using Natasha.CSharp.Builder;

namespace Natasha.CSharp.Operator
{

    /// <summary>
    /// 类构建器
    /// </summary>
    public class OopOperator : OopBuilder<OopOperator>
    {
        
        public OopOperator()
        {
            Link = this;
        }

    }
}
