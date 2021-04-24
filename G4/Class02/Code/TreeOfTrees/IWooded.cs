using System;
using System.Collections.Generic;
using System.Text;

namespace TreeOfTrees
{
    public interface IWooded
    {
        List<Tree> Trees { get; set; }

        void Deforestation();

        void Forestation();
    }
}
