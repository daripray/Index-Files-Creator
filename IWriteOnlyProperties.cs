using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Creator
{
    public interface IWriteOnlyProperties
    {
        void SetPath(string value);
        void SetChkExclude(bool value);
        void SetExcludeFolders(List<string> folders);

    }
}
