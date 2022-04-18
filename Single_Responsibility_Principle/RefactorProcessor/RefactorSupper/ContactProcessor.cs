using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle.RefactorProcessor.RefactorSupper
{
    public class ContactProcessor
    {
        public void Process(IContactDataProvider cdp, IContactParser cp, IContactWriter cw)
        {
            var providedData = cdp.Read();
            var parsedData = cp.Parse(providedData);
            cw.Write(parsedData);
        }

    }
}
