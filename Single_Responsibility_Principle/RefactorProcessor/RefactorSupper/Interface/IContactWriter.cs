using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle.RefactorProcessor.RefactorSupper
{
    public interface IContactWriter
    {
        void Write(List<People> peoples);
    }
}
