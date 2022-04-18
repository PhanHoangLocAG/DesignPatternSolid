using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle.RefactorProcessor.RefactorSupper
{
    public interface IContactParser
    {
        List<People> Parse(string contactList);
    }

}
