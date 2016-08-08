using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QLBanVeXemPhim
{
    class DataUtils
    {
        public static bool IsNewDataRow(DataRow r)
        {
            return (r.RowState == DataRowState.Added || r.RowState == DataRowState.Detached);
        }
    }
}
